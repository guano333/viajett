var viajett;
(function (viajett) {
    var LogEntries = /** @class */ (function () {
        function LogEntries() {
        }
        LogEntries.prototype.loadLogEntries = function () {
            $.ajax({
                url: '/Home/LogTime',
                type: 'GET',
                success: function (result) {
                    $("#logtimecontent").html(result);
                }
            });
        };
        return LogEntries;
    }());
    viajett.LogEntries = LogEntries;
})(viajett || (viajett = {}));
//# sourceMappingURL=LogEntries.js.map