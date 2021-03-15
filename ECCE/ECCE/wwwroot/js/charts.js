
function ColumnChart() {
    google.charts.load('current', { packages: ['corechart'] })
    google.charts.setOnLoadCallback(drawChart)

    function drawChart() {
        const container = document.querySelector('#Column')
        const data = new google.visualization.arrayToDataTable([
            ['Vendas', 'Valor', { role: 'style'}],
            ['Novembro', 5980.98 , 'green' ],
            ['Dezembro', 9000, 'blue'],
            ['Janeiro', 8000, 'gold'],
            ['Fevereiro', 5000, 'silver'],
            ['Março', 2000, 'pink']
        ])
        const options = {
            title: 'Dragon Ball Z - Characters Ki',
            height: 450,
            width: 450,

        }

        const chart = new google.visualization.ColumnChart(container)
        // const chart = new google.visualization.BarChart(container)
        // const chart = new google.visualization.LineChart(container)
        //const chart = new google.visualization.PieChart(container)
        chart.draw(data, options)
    }
}
ColumnChart()

function barChart() {
    google.charts.load('current', { packages: ['corechart'] })
    google.charts.setOnLoadCallback(drawChart)

    function drawChart() {
        const container = document.querySelector('#Bar')
        const data = new google.visualization.arrayToDataTable([
            ['Vendas', 'Valor', { role: 'style' }],
            ['Novembro', 5980.98, 'green'],
            ['Dezembro', 9000, 'blue'],
            ['Janeiro', 8000, 'gold'],
            ['Fevereiro', 5000, 'silver'],
            ['Março', 2000, 'pink']
        ])
        const options = {
            title: 'Dragon Ball Z - Characters Ki',
            height: 450,
            width: 450,
            bar: { groupWidth: '75%' },
        }

        //const chart = new google.visualization.ColumnChart(container)
        const chart = new google.visualization.BarChart(container)
        // const chart = new google.visualization.LineChart(container)
        //const chart = new google.visualization.PieChart(container)
        chart.draw(data, options)
    }
}
barChart()
// grafico 
function lineChart() {
    google.charts.load('current', { packages: ['corechart'] })
    google.charts.setOnLoadCallback(drawChart)

    function drawChart() {
        const container = document.querySelector('#Line')
        const data = new google.visualization.arrayToDataTable([
            ['Vendas', 'Valor', { role: 'style' }],
            ['Novembro', 5980.98, 'green'],
            ['Dezembro', 9000, 'blue'],
            ['Janeiro', 8000, 'gold'],
            ['Fevereiro', 5000, 'silver'],
            ['Março', 2000, 'pink']
        ])
        const options = {
            title: 'Dragon Ball Z - Characters Ki',
            height: 400,
            width: 450,
        }

        //const chart = new google.visualization.ColumnChart(container)
        //const chart = new google.visualization.BarChart(container)
        const chart = new google.visualization.LineChart(container)
        //const chart = new google.visualization.PieChart(container)
        chart.draw(data, options)
    }
}
lineChart()

function pieChart() {
    google.charts.load('current', { packages: ['corechart'] })
    google.charts.setOnLoadCallback(drawChart)

    function drawChart() {
        const container = document.querySelector('#Pie')
        const data = new google.visualization.arrayToDataTable([
            ['Vendas', 'Valor', { role: 'style' }],
            ['Novembro', 5980.98, 'green'],
            ['Dezembro', 9000, 'blue'],
            ['Janeiro', 8000, 'gold'],
            ['Fevereiro', 5000, 'silver'],
            ['Março', 2000, 'pink']
        ])
        const options = {
            title: 'Dragon Ball Z - Characters Ki',
            height: 400,
            width: 450,
            is3D: true,
        }

        //const chart = new google.visualization.ColumnChart(container)
        // const chart = new google.visualization.BarChart(container)
        // const chart = new google.visualization.LineChart(container)
        const chart = new google.visualization.PieChart(container)
        chart.draw(data, options)
    }
}
pieChart()

function donutsChart() {
    google.charts.load('current', { packages: ['corechart'] })
    google.charts.setOnLoadCallback(drawChart)

    function drawChart() {
        const container = document.querySelector('#Donuts')
        const data = new google.visualization.arrayToDataTable([
            ['Vendas', 'Valor', { role: 'style' }],
            ['Novembro', 5980.98, 'green'],
            ['Dezembro', 9000, 'blue'],
            ['Janeiro', 8000, 'gold'],
            ['Fevereiro', 5000, 'silver'],
            ['Março', 2000, 'pink']
        ])
        const options = {
            title: 'Dragon Ball Z - Characters Ki',
            pieHole: 0.4,
            height: 450,
            width: 450,
        }

        //const chart = new google.visualization.ColumnChart(container)
        // const chart = new google.visualization.BarChart(container)
        // const chart = new google.visualization.LineChart(container)
        //const chart = new google.visualization.PieChart(container)
        const chart = new google.visualization.PieChart(container)
        chart.draw(data, options)
    }
}
donutsChart()