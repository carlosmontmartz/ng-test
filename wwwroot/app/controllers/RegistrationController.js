app.controller('RegistrationController', function($scope, $location){

$scope.mChilds = "Browser Childs";
$scope.mMoms = "Browser Moms";

var elements = [{ "Property1":"Value1", "Property2":"Value2", "Property3":"Value3" }, 
{ "Property1":"Value4", "Property2":"Value5", "Property3":"Value6" }]; 

$scope.cart = elements;

    function navigateTo(url) {
        $location.path(url);
    }

 $scope.addRegister = function(){
        elements.push({ "Property1":"Value1", "Property2":"Value2", "Property3":"Value3" });
    }

    $scope.removeRegister = function(item){
        var index = $scope.cart.indexOf(item);
        var let = $scope.cart.splice(index, 1);
    }
});