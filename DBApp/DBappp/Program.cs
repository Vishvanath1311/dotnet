using System.Data;
using Google.Protobuf;
using MySql.Data.MySqlClient;
//create connection object 
MySqlConnection conn=new MySqlConnection();

//set connection string to connection object
conn.ConnectionString="server=192.168.10.150;port=3306;user=dac37;password=welcome;database=dac37";
//defined sql query
//String query= "select *from emp";

//update query
// string query="update dept set dname='Mechanical',loc='Ahmednagar' where DEPTNO=60";

//delete query
// string query="delete from dept where deptno=60";

//aggregate function query
//string query="select count(*)from dept";

// Console.WriteLine("Enter the id to update: ");
// int id=int.Parse(Console.ReadLine());
//update using user given value
// string query="update books set bookName='Rich Dad Poor Dad' where bookid=@id";
// string query="update books set bookname='3idiots',type='comedy drama',cost=350 where bookid=@id";

//insert using user given value
string query="insert into books values(5,'Hbase','Paperback',760)";



//create command object
MySqlCommand command=new MySqlCommand(query,conn);

//Open connection
try{
   conn.Open();
   // for select query
   //Execute Command
//    MySqlDataReader reader=command.ExecuteReader();

//    //iterate data from reader object

//    while(reader.Read()){
//     //retrived result into DataReader
//     int empno=int.Parse(reader["EMPNO"].ToString());
//     String name=reader["ENAME"].ToString();
//     String Job=reader["JOB"].ToString();
//     //Show data
//     Console.WriteLine(empno+"\t"+name+"\t"+Job);
    
   //}
   //for  update
   //for delete
//   command.ExecuteNonQuery();

//for aggregate function
// int count=int.Parse((command.ExecuteScalar()).ToString()); 
// Console.WriteLine("No of department is: "+count);

//Parameterized Query update
// command.Parameters.AddWithValue("@id",id);
// command.ExecuteNonQuery();

// command.Parameters.AddWithValue("@Id",id);
// command.ExecuteNonQuery();



//Parameterised query insert
command.ExecuteNonQuery();





}
catch(Exception e){
   Console.WriteLine(e.Message);
   }
finally{
    //close connection
    conn.Close();
}

