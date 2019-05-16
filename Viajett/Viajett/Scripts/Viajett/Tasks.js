var viajett;
(function (viajett) {
    var Tasks = /** @class */ (function () {
        function Tasks() {
        }
        Tasks.prototype.loadTasks = function () {
            $.ajax({
                url: '/Home/Tasks',
                type: 'GET',
                success: function (result) {
                    $("#taskcontent").html(result);
                }
            });
        };
        return Tasks;
    }());
    viajett.Tasks = Tasks;
})(viajett || (viajett = {}));
//# sourceMappingURL=Tasks.js.map