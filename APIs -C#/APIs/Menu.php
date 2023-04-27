<?php
if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','ecommerce_db');
    //$isAdmin=$_POST['Type'];
    
    $sql="select * from `users` ";
    $query=mysqli_query($con,$sql);
    $xml = new SimpleXMLElement('<a/>');

    if (mysqli_num_rows($query)>0)
    {
            while($row = mysqli_fetch_assoc($query)){
            $Men = $xml->addChild('a');
        
            foreach ($row as $key => $value) {
            $Men->addChild($key, $value);
            }
        }
        echo $xml->asXML();
    }
    else
    {
        echo "Sorry, No users in this menu";
    }
    
}
else 
{
    echo "No data enterd :(";
}

?>