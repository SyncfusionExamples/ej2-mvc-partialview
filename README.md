# ej2-mvc-partialview
This is simple demo application to use the syncfusion ej2 component in partial view page, Need to do following steps to create a partial view.

## Create ASP.NET Core control using getting started

https://ej2.syncfusion.com/aspnetcore/documentation/button/getting-started.html

## Created a partial view controls & Added the Syncfusion component to the partial view page

```html
<p>Use this area to provide additional information. </p>
<div>
    <h3>Essential JS 2 Datepicker component</h3>
    <ejs-datepicker id="datepicker" placeholder="Choose a Date"></ejs-datepicker>
</div>
<br />
<div>
    <h3>Essential JS 2 Timepicker component</h3>
    <ejs-timepicker id="timepicker" placeholder="Select a time"></ejs-timepicker>
</div>
<br />
<div>
    <h3>Essential JS 2 Daterangepicker component</h3>
    <ejs-daterangepicker id="daterangepicker" placeholder="Choose a Range"></ejs-daterangepicker>
</div>
<br />
<div>
    <h3>Essential JS 2 Dropdownlist component</h3>
    <div>
        <ejs-dropdownlist id="games" dataSource="@ViewBag.data" placeholder="Select a game" index="2" popupHeight="220px">
            <e-dropdownlist-fields text="Game" value="Id"></e-dropdownlist-fields>
        </ejs-dropdownlist>
    </div></div>
```

## Added view bag data to the partial view control 

```javascript
namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult PartialPage()
        {
            ViewBag.data = new string[] { "Badminton", "Basketball", "Cricket", "Football", "Golf", "Gymnastics", "Hockey", "Tennis" };
            return PartialView();
        }

    }
}
```

## Create a div element for partial page controls

```html
<div class="row">
    <div id="PartialView"></div>
    </div>
```

## Read partial view controls using Ajax:

```javascript
function clickAjax() {
        var ajax = new ej.base.Ajax('/PartialPage/index', 'GET', true);
        ajax.send().then(function (result) {
            document.getElementById('id').innerHTML = result;
        });;
    }

```

## Need to Evaluate scripts manually 

```javascript
function clickAjax() {
        var ajax = new ej.base.Ajax('/PartialPage/index', 'GET', true);
        ajax.send().then(function (result) {
            document.getElementById('id').innerHTML = result;
            eval(document.getElementById('PartialView').querySelector('script').innerHTML);
        });;
    }

```
