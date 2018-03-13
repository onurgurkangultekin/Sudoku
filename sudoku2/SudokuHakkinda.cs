using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class SudokuHakkinda : Form
    {
        public SudokuHakkinda()
        {
            InitializeComponent();
            YaziEkle();
            this.ShowDialog();
        }

        private void YaziEkle()
        {
            txtSudoku.Text = "SUDOKU NEDİR?\n\nSudoku, üstün, hünerli ve şeytani zekanızı ortaya çıkaracak bir mantık bulmacasıdır ve kesinlikle bağımlılık yapar. Üstelik bulmacayı çözebilmek için matematik dehası olmanıza hiç gerek yoktur! Japonya'da 1980'lerden beri popüler olan Sudoku'nun kökeni 18. yüzyılda İsviçreli matematikçi Leonhard Euler tarafından tasarlanan Latin Kareleri'ne dayanır. Oyundaki amaç, 9 kareden oluşan her sütunu, satırı ve bloğu 1'den 9'a kadar olan rakamları içerecek şekilde, hiçbir rakamı tekrarlamadan veya atlamadan doldurmaktır. Kolay görünüyor değil mi? Çünkü gerçekten kolay! Yeter ki kendinize inanın ve silginiz yanınızda olsun :) . Sudoku bulmacalarını herkes çözebilir. Üstelik çözdükçe daha da kolaylaştıklarını fark edersiniz. Unutmayın, şu andan itibaren rakamlara bakışınız sonsuza dek değişebilir :).\n\nNASIL OYNANIR?\n\nSudoku'nun kuralları son derece basittir; kuralları anlamak için matematikçi olmanıza gerek yok. Zor Sudoku'ların çözümü bazen uzun sürmekle birlikte, zorluk derecesi ne olursa olsun çözüm yöntemi hep aynıdır. Toplamda 9 x 9 = 81 kare olan kümelere 1'den 9'a kadar rakamlar yerleştirilir. Her bir rakam,  3 x 3 = 9 kareden oluşan bloklarda da sadece bir kez bulunabilir. Bulmacayı tamamlamak için tabloyu öyle bir şekilde doldur-malısınız ki dokuz kareden oluşan her satır, her sütun ve her blok 1'den 9'a kadar bütün rakamları içersin, hiçbir rakam tekrarlanmasın ve eksik kalmasın. Bazı rakamlar bulmacaya zaten yerleştirilmiş olacaktır. Bu rakamlar ne kadar artarsa bulmaca o kadar kolaylaşır. İlk olarak tabloyu gözünüzle tarayın; hangi rakamların yatay ve dikey üçlü bloklardan oluşan gruplarda birden fazla bulunduğunu tespit edin. Örneğin 1. sütunda bir rakam 3. sütunda da tekrarlanıyorsa o rakam 2. sütunda bir yerde bulunmalıdır ve bu yer sadece o rakamı içeren blok olabilir. Şimdi o bloğun bulunduğu yatay katmandaki (üçlü blok grubu) blokları inceleyerek, aynı rakamın yatay satırlardan birinde yer alıp almadığına bakın.Eğer yer alıyorsa, o rakamın, ilk dikey katmandaki bloğun aynı satırında bulunma ihtimali ortadan kalkar. Üçlü yatay ve dikey bloklardan oluşan bütün katmanları sistematik bir şekilde inceleyin ve mümkün olduğunca fazla boşluğu doldurmaya çalışın. Hiç boşluk kalmadığında ve aynı satır yada sütunlarda rakam tekrarı olmadığında işlem bitmiş olacak ve sudoku çözülmüş olacaktır. Sudoku ALIŞKANLIK yapar. Uyarmadı demeyin. İyi şanslar...";
        }
       
    }
}
