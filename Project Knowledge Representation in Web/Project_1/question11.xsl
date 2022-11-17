<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	
        <xsl:template match="/">
		<html>
			<body>
			<h2>Schedule</h2>
				<table border="1">
                                        <tr bgcolor="grey">
                                                <th>Title</th>
                                                <th>Professor</th>
                                                <th>Day</th>
                                        </tr>

                                        <xsl:for-each select="Schedule/Lesson[Lecture/Day='Monday']">
                                        <tr bgcolor="red">
                                                <td><xsl:value-of select="Title"/></td>
                                                <td><xsl:value-of select="Professor"/></td>
                                                <td>Monday</td>
                                        </tr>
                                        </xsl:for-each>

                                        <xsl:for-each select="Schedule/Lesson[Lecture/Day='Tuesday']">
                                        <tr bgcolor="orange">
                                                <td><xsl:value-of select="Title"/></td>
                                                <td><xsl:value-of select="Professor"/></td>
                                                <td>Tuesday</td>
                                        </tr>
                                        </xsl:for-each>

                                        <xsl:for-each select="Schedule/Lesson[Lecture/Day='Wednesday']">
                                        <tr bgcolor="blue">
                                                <td><xsl:value-of select="Title"/></td>
                                                <td><xsl:value-of select="Professor"/></td>
                                                <td>Wednesday</td>
                                        </tr>
                                        </xsl:for-each>
                                        
                                        <xsl:for-each select="Schedule/Lesson[Lecture/Day='Thursday']">
                                        <tr bgcolor="yellow">
                                                <td><xsl:value-of select="Title"/></td>
                                                <td><xsl:value-of select="Professor"/></td>
                                                <td>Thursday</td>
                                        </tr>
                                        </xsl:for-each>

                                        <xsl:for-each select="Schedule/Lesson[Lecture/Day='Friday']">
                                        <tr bgcolor="magenta">
                                                <td><xsl:value-of select="Title"/></td>
                                                <td><xsl:value-of select="Professor"/></td>
                                                <td>Friday</td>
                                        </tr>
                                        </xsl:for-each>
                                        
                                        <xsl:for-each select="Schedule/Lesson[Lecture/Day='Saturday']">
                                        <tr bgcolor="green">
                                                <td><xsl:value-of select="Title"/></td>
                                                <td><xsl:value-of select="Professor"/></td>
                                                <td>Saturday</td>
                                        </tr>
                                        </xsl:for-each>

                                        <xsl:for-each select="Schedule/Lesson[Lecture/Day='Sunday']">
                                        <tr bgcolor="lightgreen">
                                                <td><xsl:value-of select="Title"/></td>
                                                <td><xsl:value-of select="Professor"/></td>
                                                <td>Sunday</td>
                                        </tr>
                                        </xsl:for-each>







				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>