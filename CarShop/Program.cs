
using CarShop;

var ViktorsVerksted = new Shop();

for (var i = 0; i < ViktorsVerksted.Cars.Count; i++)
{
    ViktorsVerksted.RunShop(ViktorsVerksted.Cars[i]);
}
