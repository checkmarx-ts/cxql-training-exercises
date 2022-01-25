package com.confierhealth.dataplatform.util

import scala.io.StdIn
import java.sql.{Connection, DriverManager, ResultSet}
import scala.sys.process.Process


object DBConnection {

def getUserId() {
val userInput = StdIn.readLine()
val query = "select user_id from User where user = " + userInput
Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");  
val conn = DriverManager.getConnection("jdbc:sqlserver://localhost;database=AdventureWorks;integratedSecurity=true;")
val statement = conn.createStatement()                                     
    val rs = statement.executeQuery(query)                                          
    while (rs.next){
    println("result set found")
    }                         
conn.close()
}

def cmd(input: String): String = {	return Process(input).!!}

def cmd1(input: String): Unit = {	var proc = scala.sys.process.stringToProcess(input);    proc.run();}

getUserId()

cmd(StdIn.readLine)

cmd1(StdIn.readLine)
}
