app.controller("editAdmin",function($scope, $http, ajax, $routeParams){
    ajax.get(API_ROOT+"api/Admin/"+$routeParams.id+"/Edit",function(response){
        console.log(response.data);
        $scope.editAdmin = response.data;
    },
    function(error){
    });

    $scope.saveAdmin = function(a){
        ajax.post(API_ROOT+"api/Admin/"+$routeParams.id+"/Edit",a,
        function(response){
            $location.path("/Admin/All");
        },
        function(err){

        });
    };
});