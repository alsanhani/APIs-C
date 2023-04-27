<?php

if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','resturant');
    $Menu=$_POST['Type'];
    
    //$sql="INSERT INTO `menu` (`Type`, `id`, `Food_name`, `Price`) VALUES ('$Menu', NULL, '', '')";
    $sql="select * from `menu` where `Type` like '$Menu'";
    $query=mysqli_query($con,$sql);
    $menuarray = array();

    if (mysqli_num_rows($query)>0)
    {
            while($row = mysqli_fetch_assoc($query)){
                $menuarray[] = $row;
        }
        echo json_encode($menuarray);
    }
    else
    {
        echo "Sorry, No food in this menu";
    }
    
}
else 
{
    echo "No data enterd :(";
}

?>