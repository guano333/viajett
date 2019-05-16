namespace viajett {
    export class LogEntries {
        loadLogEntries() {
            $.ajax({
                url: '/Home/LogTime',
                type: 'GET',
                success: (result) => {
                    $("#logtimecontent").html(result);
                }
            });
        }
    }   
}