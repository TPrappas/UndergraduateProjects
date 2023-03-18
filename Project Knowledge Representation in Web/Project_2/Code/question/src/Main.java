import java.util.Random;
import java.util.Scanner;
import java.io.*;

import org.apache.jena.query.Query;
import org.apache.jena.query.QueryExecution;
import org.apache.jena.query.QueryExecutionFactory;
import org.apache.jena.query.QueryFactory;
import org.apache.jena.query.QuerySolution;
import org.apache.jena.query.ResultSet;
import org.apache.jena.query.ResultSetFormatter;
import org.apache.jena.rdf.model.Model;
import org.apache.jena.rdf.model.ModelFactory;
import org.apache.jena.rdf.model.Property;
import org.apache.jena.rdf.model.RDFNode;
import org.apache.jena.rdf.model.Resource;
import org.apache.jena.riot.RDFDataMgr;
import org.apache.jena.riot.RDFFormat;
import org.apache.jena.util.FileManager;
import org.apache.jena.vocabulary.RDF;

public class Main {

    // Changes base on our file name
    static final String FileName = "question3.rdf";

    public static void main(String[] args) throws IOException {

        Model model = ModelFactory.createDefaultModel();
        InputStream in1 = FileManager.get().open(FileName);
        model.read(in1, "");
        //model.write(System.out);
        Scanner inputReader = new Scanner(System.in);
        String input = " ";
        String department;
        String dc = "https://eclass.upatras.gr/";

            // Choose an option
            System.out.println("Choose A, B or C:");
            input = inputReader.nextLine();

            if (input.equals("A")) {

                // Prints All Departments
                String queryString = "PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>"
                        + "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>"
                        + "PREFIX dc: <https://eclass.upatras.gr/>"
                        + "SELECT ?name "
                        + " WHERE "
                        + "{?dep rdf:type dc:Department."
                        + "?dep dc:dep_name ?name"
                        + "}";

                Query query = QueryFactory.create(queryString);
                QueryExecution qexec = QueryExecutionFactory.create(query, model);
                ResultSet rs = qexec.execSelect();

               for (; rs.hasNext();)
               {
                   QuerySolution rb = rs.nextSolution();
                   RDFNode dep = rb.get("name");
                   System.out.println(dep.toString());
               }

               // Choose a Department for more Info
                System.out.println("Choose a Department: ");

                department = null;
                Scanner inputReader1 = new Scanner(System.in);
                department = inputReader1.nextLine();

                // Prints All Professors
                String queryString1 = "PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>"
                        + "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>"
                        + "PREFIX dc: <https://eclass.upatras.gr/>"
                        + "SELECT ?Name ?Age ?Phone ?Email "
                        + " WHERE "
                        + "{?a rdf:type dc:Professor."
                        + "?a dc:member_of ?dep."
                        + "?dep dc:dep_name '" + department + "'.\n"
                        + "?a dc:has_name ?Name."
                        + "?a dc:has_age ?Age."
                        + "?a dc:has_phone ?Phone."
                        + "?a dc:has_email ?Email."
                        + "}";

                Query query1 = QueryFactory.create(queryString1);
                QueryExecution qexec1 = QueryExecutionFactory.create(query1, model);
                ResultSet rs1 = qexec1.execSelect();
                System.out.println("Professors: ");
                ResultSetFormatter.out(System.out, (org.apache.jena.query.ResultSet) rs1, query1);

                // Prints All Students
                String queryString2 = "PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>"
                        + "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>"
                        + "PREFIX dc: <https://eclass.upatras.gr/>"
                        + "SELECT ?Name ?Age ?Phone ?Email "
                        + " WHERE "
                        + "{?a rdf:type dc:Student."
                        + "?a dc:member_of ?dep."
                        + "?dep dc:dep_name '" + department + "'.\n"
                        + "?a dc:has_name ?Name."
                        + "?a dc:has_age ?Age."
                        + "?a dc:has_phone ?Phone."
                        + "?a dc:has_email ?Email."
                        + "}";;

                Query query2 = QueryFactory.create(queryString2);
                QueryExecution qexec2 = QueryExecutionFactory.create(query2, model);
                ResultSet rs2 = qexec2.execSelect();
                System.out.println("Students: ");
                ResultSetFormatter.out(System.out, (org.apache.jena.query.ResultSet) rs2, query2);

                // Prints All Lessons
                String queryString3 = "PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>"
                        + "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>"
                        + "PREFIX dc: <https://eclass.upatras.gr/>"
                        + "SELECT ?Name ?Professor "
                        + " WHERE "
                        + "{?b dc:les_name ?Name."
                        + "?b dc:taught_by ?a."
                        + "?a dc:has_name ?Professor."
                        + "?a dc:member_of ?dep."
                        + "?dep dc:dep_name '" + department + "'.\n"
                        + "}";;

                Query query3 = QueryFactory.create(queryString3);
                QueryExecution qexec3 = QueryExecutionFactory.create(query3, model);
                ResultSet rs3 = qexec3.execSelect();
                System.out.println("Lessons: ");
                ResultSetFormatter.out(System.out, (org.apache.jena.query.ResultSet) rs3, query3);

                // Prints All Classrooms
                String queryString4 = "PREFIX rdf: <http://www.w3.org/1999/02/22-rdf-syntax-ns#>"
                        + "PREFIX rdfs: <http://www.w3.org/2000/01/rdf-schema#>"
                        + "PREFIX dc: <https://eclass.upatras.gr/>"
                        + "SELECT ?Name ?Capacity "
                        + " WHERE "
                        + "{?b rdf:type dc:Classroom."
                        + "?b dc:room_name ?Name."
                        + "?b dc:room_department ?dep."
                        + "?b dc:room_capacity ?Capacity."
                        + "?dep dc:dep_name '" + department + "'.\n"
                        + "}";

                Query query4 = QueryFactory.create(queryString4);
                QueryExecution qexec4 = QueryExecutionFactory.create(query4, model);
                ResultSet rs4 = qexec4.execSelect();
                System.out.println("Classrooms: ");
                ResultSetFormatter.out(System.out, (org.apache.jena.query.ResultSet) rs4, query4);
            }
            if (input.equals("B")) {

                System.out.println("Name of Data to Insert ");

                Scanner inputReader3 = new Scanner(System.in);
                String input2 = null;
                Scanner inputReader2 = new Scanner(System.in);
                input2 = inputReader2.nextLine();

                if (input2.equals("Professor")) {
                    String name = null;
                    String phone = null;
                    String email = null;
                    String age = null;
                    String member_of = null;
                    String teaches = null;

                    Random r = new Random();
                    int low = 20;
                    int high = 100;
                    int result = r.nextInt(high-low) + low;

                    //get data from user
                    System.out.println("Name:");
                    name = inputReader3.nextLine();
                    System.out.println("Phone:");
                    phone = inputReader3.nextLine();
                    System.out.println("Email:");
                    email = inputReader3.nextLine();
                    System.out.println("Age:");
                    age = inputReader3.nextLine();
                    System.out.println("Member of:");
                    member_of = inputReader3.nextLine();
                    System.out.println("Teaches:");
                    teaches = inputReader3.nextLine();

                    //create resources and properties
                    Resource resource = model.createResource(dc + "Professor/Professor" + result);
                    Property p_name = model.createProperty(dc, "has_name");
                    Property p_phone = model.createProperty(dc, "has_phone");
                    Property p_email = model.createProperty(dc, "has_email");
                    Property p_age = model.createProperty(dc, "has_age");
                    Property p_member_of = model.createProperty(dc, "member_of");
                    Property p_teaches = model.createProperty(dc, "teaches");
                    //add values
                    resource.addProperty(RDF.type, model.getResource(dc + "Professor"));
                    resource.addProperty(p_name, name);
                    resource.addProperty(p_phone, phone);
                    resource.addProperty(p_email, email);
                    resource.addProperty(p_age, age);
                    resource.addProperty(p_member_of, model.getResource(dc + "Department/" + member_of));
                    resource.addProperty(p_teaches, model.getResource(dc + "Lesson/" + teaches));
                }
                if (input2.equals("Student")) {
                    String st_name = null;
                    String st_phone = null;
                    String st_email = null;
                    String st_age = null;
                    String st_member_of = null;

                    Random r = new Random();
                    int low = 21;
                    int high = 100;
                    int result = r.nextInt(high-low) + low;

                    //get data from user
                    System.out.println("Name:");
                    st_name = inputReader3.nextLine();
                    System.out.println("Phone:");
                    st_phone = inputReader3.nextLine();
                    System.out.println("Email:");
                    st_email = inputReader3.nextLine();
                    System.out.println("Age");
                    st_age = inputReader3.nextLine();
                    System.out.println("Member of:");
                    st_member_of = inputReader3.nextLine();

                    //create resources and properties
                    Resource resource = model.createResource(dc + "Student/Student" + result);
                    Property s_name = model.createProperty(dc, "has_name");
                    Property s_phone = model.createProperty(dc, "has_phone");
                    Property s_email = model.createProperty(dc, "has_email");
                    Property s_age = model.createProperty(dc, "has_age");
                    Property s_member_of = model.createProperty(dc, "member_of");
                    //add values
                    resource.addProperty(RDF.type, model.getResource(dc + "Student"));
                    resource.addProperty(s_name, st_name);
                    resource.addProperty(s_phone, st_phone);
                    resource.addProperty(s_email, st_email);
                    resource.addProperty(s_age, st_age);
                    resource.addProperty(s_member_of, model.getResource(dc + st_member_of));

                }
                if (input2.equals("Lesson")) {
                    String les_name = null;
                    String les_taught_by = null;

                    Random r = new Random();
                    int low = 15;
                    int high = 100;
                    int result = r.nextInt(high-low) + low;

                    //get data from user
                    System.out.println("Name:");
                    les_name = inputReader3.nextLine();
                    System.out.println("Taught by:");
                    les_taught_by = inputReader3.nextLine();

                    //create resources and properties
                    Resource resource = model.createResource(dc + "Lesson/Lesson" + result);
                    Property ls_name = model.createProperty(dc, "has_name");
                    Property ls_teaches = model.createProperty(dc, "taught-by");
                    //add values
                    resource.addProperty(ls_name, les_name);
                    resource.addProperty(ls_teaches, model.getResource(dc + "Professor/" + les_taught_by));
                }
                if (input2.equals("Department")) {
                    String dep_name = null;
                    String dep_city = null;

                    Random r = new Random();
                    int low = 10;
                    int high = 100;
                    int result = r.nextInt(high-low) + low;

                    //get data from user
                    System.out.println("Name:");
                    dep_name = inputReader3.nextLine();
                    System.out.println("City:");
                    dep_city = inputReader3.nextLine();

                    //create resources and properties
                    Resource resource = model.createResource(dc + "Department/Department" + result);
                    Property dpt_name = model.createProperty(dc, "dep_name");
                    Property dpt_city = model.createProperty(dc, "dep_city");
                    //add values
                    resource.addProperty(RDF.type, model.getResource(dc + "Department"));
                    resource.addProperty(dpt_name, dep_name);
                    resource.addProperty(dpt_city, dep_city);
                }
                if (input2.equals("Classroom")) {
                    String class_name = null;
                    String class_capacity = null;
                    String class_department = null;

                    Random r = new Random();
                    int low = 20;
                    int high = 100;
                    int result = r.nextInt(high-low) + low;

                    //get data from user
                    System.out.println("Name:");
                    class_name = inputReader3.nextLine();
                    System.out.println("Capacity:");
                    class_capacity = inputReader3.nextLine();
                    System.out.println("Department:");
                    class_department = inputReader3.nextLine();

                    //create resources and properties
                    Resource resource = model.createResource(dc + "Classroom/Classroom" + result);
                    Property r_name = model.createProperty(dc, "room_name");
                    Property r_capacity = model.createProperty(dc, "room_capacity");
                    Property r_department = model.createProperty(dc, "room_department");
                    //add values
                    resource.addProperty(RDF.type, model.getResource(dc + "Classroom"));
                    resource.addProperty(r_name, class_name);
                    resource.addProperty(r_capacity, class_capacity);
                    resource.addProperty(r_department, model.getResource(dc + "Department/" + class_department));
                }
                //write data to file
                try{
                    OutputStream output = new FileOutputStream("question3.rdf");
                    RDFDataMgr.write(output, model, RDFFormat.RDFXML_PLAIN);
                }
                catch(IOException e){
                    System.err.println("Error: " + e);
                }

            }
        }
    }
