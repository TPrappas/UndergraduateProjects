using VDS.RDF.Ontology;
using VDS.RDF.Parsing;
using VDS.RDF.Query.Inference;
using VDS.RDF;

namespace OwlTranslator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Initialize the file path to owl file
            var owlFilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Basketball.owl";
            var newOwlFilePath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\BasketballNew.owl";

            // Declare a owl graph
            var owlGraph = new OntologyGraph();

            // Load the owl file
            FileLoader.Load(owlGraph, owlFilePath);

            // Declare a owl inference reasoner
            var infernceReasoner = new StaticRdfsReasoner();

            // Initialize using the owl file
            infernceReasoner.Initialise(owlGraph);

            // Apply the owl to the inference reasoner
            infernceReasoner.Apply(owlGraph);

            Console.WriteLine("\nOptions:\n1. Search for the instances based on a property\n2. Add new instances\n3. Search for instances based on a class");

            // Read the user choice
            var input = int.Parse(Console.ReadLine());

            if (input == 1)
                // Search for instances in the owl file
                SearchInstances(owlGraph);

            if (input == 2)
                // Add new instances in the owl file
                AddInstances(owlGraph, newOwlFilePath);

            if (input == 3)
                // Print the  instances in the owl file
                PrintInstances(owlGraph);
        }


        /// <summary>
        /// The function for printing the instances
        /// </summary>
        /// <param name="ontologyGraph">The owl graph</param>
        public static void SearchInstances(OntologyGraph ontologyGraph)
        {
            // Get all defined properties
            var properties = ontologyGraph.AllProperties;

            // For every property...
            foreach (var property in properties)
            {
                if(property.Resource.ToString().Contains("http://www.semanticweb.org/linos/ontologies/2023/0/Basketball#"))
                // Print the property name
                Console.WriteLine(property.Resource.ToString().Replace("http://www.semanticweb.org/linos/ontologies/2023/0/Basketball#", string.Empty));
            }

            Console.WriteLine("\nPlease enter the name of the property (fragement with '#') bellow.\n");

            // Read the user choice
            var selectedUri = Console.ReadLine();

            // Get the selected property
            var selectedProperty = properties.FirstOrDefault(x => x.Resource.ToString().Replace(x.Resource.GraphUri.ToString(), string.Empty) == selectedUri);

            Console.WriteLine("\nEnter the property value:\n");

            // Read the user choice
            var input = Console.ReadLine();

            // Get all the triples
            var triples = selectedProperty.TriplesWithPredicate.Where(x =>
            {
                // If the object node is literal...
                if (x.Object.NodeType == NodeType.Literal)
                {
                    // Typecast the node
                    var node = x.Object as LiteralNode;

                    // Check the value
                    return node.Value == input;
                }
                else
                {
                    // Typecast the node
                    var node = x.Object as UriNode;

                    // Check the uri
                    return node.Uri.ToString() == input;
                }
            });

            Console.WriteLine("\nInstances:\n");

            // For every triple...
            foreach (var triple in triples)
            {
                // Print the triple subject
                Console.WriteLine(triple.Subject);
            }
        }

        /// <summary>
        /// The function for adding instances
        /// </summary>
        /// <param name="ontologyGraph">The owl graph</param>
        /// <param name="owlFilePath">The owl file path</param>
        public static void AddInstances(OntologyGraph ontologyGraph, string owlFilePath)
        {
            Console.WriteLine("Please enter the class name bellow.");
            var individualClassName = Console.ReadLine();

            // Set the uri of the node
            Console.WriteLine("Please enter the individual name bellow.");
            var individualName = Console.ReadLine();

            // Add the uri node as an individual
            ontologyGraph.CreateIndividual(new Uri($"http://www.semanticweb.org/linos/ontologies/2023/0/Basketball#{individualName}"), new Uri($"http://www.semanticweb.org/linos/ontologies/2023/0/Basketball#{individualClassName}"));

            // Save the graph to the file
            ontologyGraph.SaveToFile(owlFilePath);

            Console.WriteLine("Updated was successful.");
        }

        /// <summary>
        /// The function for printing instances
        /// </summary>
        /// <param name="ontologyGraph">The owl graph</param>
        public static void PrintInstances(OntologyGraph ontologyGraph)
        {
            // Get all classes
            var classes = ontologyGraph.AllClasses;

            // For every class...
            foreach (var owlClass in classes)
            {
                if(owlClass.Resource.ToString().Contains("#"))
                {
                    var fragement = owlClass.Resource.ToString().Replace(owlClass.Resource.GraphUri.ToString(), string.Empty);
                    // Print the uri
                    Console.WriteLine(owlClass.Resource.ToString());
                    Console.WriteLine(fragement);
                }
            }

            Console.WriteLine("Please enter the name of the class (fragement with '#') bellow.\n");

            // Read the user choice
            var selectedUri = Console.ReadLine();

            var selectedClass = classes.FirstOrDefault(x => x.Resource.ToString().Replace(x.Resource.GraphUri.ToString(), string.Empty) == selectedUri);
            
            if(selectedClass is null)
            {
                Console.WriteLine("\nNothing exists. Bye bye :)\n");
                return;
            }

            Console.WriteLine($"\n{selectedUri.Replace("#", string.Empty)} class Instances:\n");

            // Get the selected class

            // For every class...
            foreach (var instance in selectedClass.Instances)
            {
                // Print the class fragement
                Console.WriteLine("### __________ ###");
                Console.WriteLine(instance.Resource.ToString());
                Console.WriteLine(instance.Resource.ToString().Replace(instance.Resource.GraphUri.ToString(), string.Empty).Replace("#", string.Empty));
                Console.WriteLine("### __________ ###\n");

            }
        }
    }
}