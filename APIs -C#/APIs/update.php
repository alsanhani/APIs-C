<?php

if(isset($_POST))
{ 
    //require_once "conn.php";
    $con=mysqli_connect('localhost','root','','ecommerce_db');
    //require_once "validate.php";
    $username=$_POST['name'];
    $fname=$_POST['fname'];
    $lname=$_POST['lname'];
    $password=$_POST['password'];
    $email = $_POST['email'];
    $Admin = "No";

    //$sql="insert into users(username,fname,lname,password,email,isAdmin) values('$username','$fname','$lname', '" . md5($password) . "','$email','$Admin')";
    $sql="update users set fname='$fname',lname='$lname',password='$password',email='$email' WHERE username='$username'";
    
    if(mysqli_query($con,$sql))
    {
        echo "updete successfuly";
    }
    else
    {
        echo  "An error Accured";
    }

}



?>