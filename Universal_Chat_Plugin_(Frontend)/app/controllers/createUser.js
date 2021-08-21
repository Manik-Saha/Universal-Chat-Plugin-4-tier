app.controller("createUser",function($scope,ajax,$location){
    $scope.createUser = function(u){
        ajax.post(API_ROOT+"api/User/Add",u,
        function(response){
            $scope.msg = "Registered Successfully";
            $location.path("/User/All");
        },
        function(err){

        });
    };
});