app.controller("createAdmin",function($scope,ajax,$location){
    $scope.createAdmin = function(admin){
        ajax.post(API_ROOT+"api/Admin/Add",admin,
        function(response){
            $scope.msg = "Registered Successfully";
            $location.path("/Admin/All");
        },
        function(err){

        });
    };
});