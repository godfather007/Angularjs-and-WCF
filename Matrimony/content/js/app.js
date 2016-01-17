// create the module and name it scotchApp
var matrimonyapp = angular.module('mApp', ['ngRoute']);

// configure our routes
matrimonyapp.config(function ($routeProvider) {
    $routeProvider

        // route for the home page
        .when('/', {
            templateUrl: '../view/partial/login.html',
            controller: 'AccountController'
        })

        // route for the about page
        .when('/register', {
            templateUrl: '../view/partial/register.html',
            controller: 'aboutController'
        })

        // route for the contact page
        .when('/contact', {
            templateUrl: 'pages/contact.html',
            controller: 'contactController'
        }).
        //Home  Page
        when('/home', {
            templateUrl: '../view/partial/home.html',
            controller: 'homeController'
        }).
        otherwise({
            redirectTo: '/addOrder'
        });
});

// create the controller and inject Angular's $scope
//matrimonyapp.controller('AccountController', function ($scope) {
//    // create a message to display in our view
//    $scope.message = 'Everyone come and see how good I look!';
//});

matrimonyapp.controller('homeController', function ($scope) {
    //check is token valid here when this controller call below
    debugger
    
});

matrimonyapp.controller('aboutController', function ($scope) {
    $scope.message = 'Look! I am an about page.';
});

matrimonyapp.controller('contactController', function ($scope) {
    $scope.message = 'Contact us! JK. This is just a demo.';
});