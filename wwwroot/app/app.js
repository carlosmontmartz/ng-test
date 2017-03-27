var app = angular.module('app',["ngRoute"]);
app.config( function ($routeProvider, $locationProvider) {
    $routeProvider
    .when("register/Childs", {
        templateUrl : "../../app/templates/Childs.html"
    })
    .when("register/Moms", {
        templateUrl : "../../app/templates/Moms.html"
    });

});
