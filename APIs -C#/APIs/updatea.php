<?php

if(isset($_POST))
{ 
    //require_once "conn.php";
    $con=mysqli_connect('localhost','root','','ecommerce_db');
    //require_once "validate.php";
    $username=$_POST['name'];
    $isAdmin = $_POST['isAdmin'];

    //$sql="insert into users(username,fname,lname,password,email,isAdmin) values('$username','$fname','$lname', '" . md5($password) . "','$email','$Admin')";
    $sql="update users set isAdmin='$isAdmin' WHERE username='$username'";
    
    if(mysqli_query($con,$sql))
    {
        echo " successfuly";
    }
    else
    {
        echo  "An error Accured";
    }

}



?>