using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.IO;
using System;


// W projektach w stylu zestawu SDK, takich jak ten, kilka atrybutów zestawu, kiedyś
// definiowanych w tym pliku, jest teraz automatycznie dodawanych podczas kompilacji
// i wypełnianych wartościami zdefiniowanymi we właściwościach projektu. Aby uzyskać
// szczegółowe informacje o tym, które atrybuty są dołączane i jak dostosować ten
// proces, zobacz: https://aka.ms/assembly-info-properties


// Ustawienie atrybutu ComVisible na wartość false sprawia, że typy w tym zestawie
// nie są widoczne dla składników modelu COM. Jeśli chcesz uzyskać dostęp do typu
// w tym zestawie z modelu COM, ustaw w tym typie atrybut ComVisible na wartość true.

[assembly: ComVisible(true)]

// Następujący identyfikator GUID jest identyfikatorem elementu typelib w przypadku
// udostępnienia tego projektu w modelu COM.

[assembly: Guid("d6531b6a-6e64-4f92-90b4-edee55265051")]

public class FizzBuzz
{
    [Display(Name = "Twój szczęśliwy numerek")]

    [Required, Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
    
    public int? Number { get; set; }

}

