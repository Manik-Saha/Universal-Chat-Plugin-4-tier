app.controller("editUser",function($scope, $http, ajax, $routeParams){
    ajax.get(API_ROOT+"api/User/"+$routeParams.id+"/Edit",function(response){
        console.log(response.data);
        $scope.editUser = response.data;
    },
    function(error){
    });

    $scope.saveUser = function(o){
        ajax.post(API_ROOT+"api/User/"+$routeParams.id+"/Edit",o,
        function(response){
            $location.path("/User/All");
        },
        function(err){

        });
    };
});