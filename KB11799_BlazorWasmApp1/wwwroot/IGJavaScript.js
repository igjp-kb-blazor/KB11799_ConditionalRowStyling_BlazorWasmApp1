igRegisterScript("RowClassesHandler", () => {
    return {
        low: (row) => {
            return row.data.StockedAmount < 10;
        },
        high: (row) => {
            return row.data.StockedAmount > 50;
        }
    };
}, true);
