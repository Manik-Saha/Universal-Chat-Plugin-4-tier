var app = angular.module("UniversalChatPlugin", ["ngRoute"]);
var API_ROOT = "https://localhost:44343/";
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/index.html"
    })

    .when("/Admin/All", {
        templateUrl : "views/pages/admin/all.html",
        controller: 'allAdmin'
    })
    .when("/Admin/Create", {
        templateUrl : "views/pages/admin/create.html",
        controller: 'createAdmin'
    })
    .when("/Admin/Delete/:id", {
        templateUrl : "views/pages/admin/delete.html",
        controller: 'deleteAdmin'
    })
    .when("/Admin/Details/:id", {
        templateUrl : "views/pages/admin/details.html",
        controller: 'detailsAdmin'
    })
    .when("/Admin/Edit/:id", {
        templateUrl : "views/pages/admin/edit.html",
        controller: 'editAdmin'
    })

    .when("/Organization/All", {
        templateUrl : "views/pages/organization/all.html",
        controller: 'allOrganization'
    })
    .when("/Organization/Create", {
        templateUrl : "views/pages/organization/create.html",
        controller: 'createOrganization'
    })
    .when("/Organization/Delete/:id", {
        templateUrl : "views/pages/organization/delete.html",
        controller: 'deleteOrganization'
    })
    .when("/Organization/Details/:id", {
        templateUrl : "views/pages/organization/details.html",
        controller: 'detailsOrganization'
    })
    .when("/Organization/Edit/:id", {
        templateUrl : "views/pages/organization/edit.html",
        controller: 'editOrganization'
    })
    
    .when("/User/All", {
        templateUrl : "views/pages/user/all.html",
        controller: 'allUser'
    })
    .when("/User/Create", {
        templateUrl : "views/pages/user/create.html",
        controller: 'createUser'
    })
    .when("/User/Delete/:id", {
        templateUrl : "views/pages/user/delete.html",
        controller: 'deleteUser'
    })
    .when("/User/Details/:id", {
        templateUrl : "views/pages/user/details.html",
        controller: 'detailsUser'
    })
    .when("/User/Edit/:id", {
        templateUrl : "views/pages/user/edit.html",
        controller: 'editUser'
    })

    .when("/login", {
        templateUrl : "views/pages/login/index.html",
        controller: 'login'
    })    
    .otherwise({
        redirectTo:"/"
    });

}]);
