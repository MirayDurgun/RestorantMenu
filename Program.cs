using System;

namespace RestorantMenu
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region degiskenler
			double toplam = 0;
			double fiyat = 0;
			int kebapEkstraFiyat = 0;
			int tatliEkstraFiyat = 0;
			#endregion
			Console.WriteLine("Hoşgeldiniz, kaç kişilik sipariş oluşturulacağını öğrenebilir miyim?\n");
			Console.WriteLine("Lütfen kaç kişiyseniz sayı ile giriniz örnek '1'");
			int kisiSayisi = int.Parse(Console.ReadLine());
			Console.Clear();

			double[] almanUsulu = new double[kisiSayisi];
			for (int i = 0; i < kisiSayisi; i++)
			{

				Console.WriteLine($"{i + 1}. kişi, adınız nedir?");
				string ad = Console.ReadLine().ToUpper();
				Console.Clear();
				bool anaMenuDonme = false;
				bool hesapMenuDonme = false;
				//değişken false olduğu sürece döngüye girer true olduğunda çıkar

				do
				{
					#region menu
					Console.WriteLine($"Tekrar Hoşgeldin {ad}, lütfen bakmak istediğin menüyü yazar mısın?");
					Console.WriteLine("\n-Kebap\n-Çorba\n-Meze\n-Salata\n-Tatlı\n-İçecek\n-Ekstra\n");
					Console.WriteLine("-Hesap\n");
					Console.WriteLine("Menüden çıkmak için veya sonrki kişinin sipariş verebilmesi için 'x'e bas.");
					Console.WriteLine("Seçtiğin ürünlerin toplam tutarını görmek için hesap yazman yeterli.\n");
					Console.WriteLine("Lütfen bakmak istediğin menü adını yazar mısın?");
					string anaMenu = Console.ReadLine().ToLower();
					Console.Clear();
					#endregion

					switch (anaMenu)
					{
						case "kebap":

							Console.WriteLine("Kebap Menüsü\n");
							Console.WriteLine("1. Adana = 150 TL");
							Console.WriteLine("2. Urfa = 150 TL");
							Console.WriteLine("3. Çöp Şiş = 150 TL");
							Console.WriteLine("4. Patlıcan Kebabı = 250 TL");
							Console.WriteLine("5. Karışık Izgara = 200 TL");
							Console.WriteLine("6. Beyti = 250 TL");
							Console.WriteLine("7. Adana Dürüm = 80 TL");
							Console.WriteLine("8. Urfa Dürüm = 80 TL");
							Console.WriteLine("9. Lahmacun = 35 TL");
							Console.WriteLine("10. Fındık Lahmacun = 15 TL\n");
							Console.WriteLine("Lütfen seçtiğiniz ürünün numarasını girin.");
							Console.WriteLine("Örnek Adana için '1'");
							int kebapSecim = int.Parse(Console.ReadLine());
							Console.Clear();

							switch (kebapSecim)
							{
								case 1:
									Console.WriteLine("1. Adana = 150 TL");
									fiyat = 150;
									break;
								case 2:
									Console.WriteLine("2. Urfa = 150 TL");
									fiyat = 150;
									break;
								case 3:
									Console.WriteLine("3. Çöp Şiş = 150 TL");
									fiyat = 150;
									break;
								case 4:
									Console.WriteLine("4. Patlıcan Kebabı = 250 TL");
									fiyat = 250;
									break;
								case 5:
									Console.WriteLine("5. Karışık Izgara = 200 TL");
									fiyat = 200;
									break;
								case 6:
									Console.WriteLine("6. Beyti = 250 TL");
									fiyat = 250;
									break;
								case 7:
									Console.WriteLine("7. Adana Dürüm = 80 TL");
									fiyat = 80;
									break;
								case 8:
									Console.WriteLine("8. Urfa Dürüm = 80 TL");
									fiyat = 80;
									break;
								case 9:
									Console.WriteLine("9. Lahmacun = 35 TL");
									fiyat = 35;
									break;
								case 10:
									Console.WriteLine("10. Fındık Lahmacun = 15 TL");
									fiyat = 15;
									break;
								default:
									Console.WriteLine($"{ad}, bu ürün menümüzde bulunmamakta");
									break;
							}
							Console.WriteLine($"\n{ad}, yanında ekstra bir şey ister misin?\n");
							Console.WriteLine("1. Ekmek\n2. Acılı Ezme - 10 TL\n3. Yoğurt - 10 TL\n4. Patlıcan Közlemesi - 20 TL\n");
							Console.WriteLine("Lütfen seçtiğiniz ürünün numarasını girin.");
							Console.WriteLine("Örnek Ekmek için '1'\n");
							Console.WriteLine("Bir şey istemiyorsan lütfen 'h'ye bas");
							string kebapEkstraSecim = Console.ReadLine();
							Console.Clear();
							switch (kebapEkstraSecim)
							{
								case "1":
									Console.WriteLine("Ekmek ücrete tabi değildir");
									kebapEkstraFiyat = 0;
									break;
								case "2":
									Console.WriteLine("2. Acılı Ezme - 10 TL ");
									kebapEkstraFiyat = 10;

									break;
								case "3":
									Console.WriteLine("3. Yoğurt - 10 TL");
									kebapEkstraFiyat = 10;

									break;
								case "4":
									Console.WriteLine("4. Patlıcan Közleme - 20 TL");
									kebapEkstraFiyat = 20;
									break;
							}
							toplam += fiyat;
							almanUsulu[i] = fiyat;
							if (kebapEkstraSecim != null)
							{
								toplam += kebapEkstraFiyat;
								Console.WriteLine($"{ad}, seçtiğin ürün {kebapSecim}. {fiyat} TL ve ekstra seçimin {kebapEkstraSecim}. {kebapEkstraFiyat} TL. Toplam {toplam} TL\n");
							}
							else
							{
								Console.WriteLine($"{ad}, seçtiğin ürün {kebapSecim}. {fiyat} TL. Toplam {toplam} TL\n");
							}
							break;
						case "çorba":
							Console.WriteLine("Çorba Menüsü\n");
							Console.WriteLine("1. Mercimek = 25 TL");
							Console.WriteLine("2. Ezogelin = 25 TL");
							Console.WriteLine("3. Tarhana = 30 TL");
							Console.WriteLine("4. Domates = 20 TL");
							Console.WriteLine("5. Tavuk = 40 TL");
							Console.WriteLine("6. İşkembe = 50 TL\n");
							Console.WriteLine("Lütfen seçtiğiniz ürünün numarasını girin.");
							Console.WriteLine("Örnek Mercimek Çorbası için '1'");
							int corbaSecim = int.Parse(Console.ReadLine());
							Console.Clear();
							switch (corbaSecim)
							{
								case 1:
									Console.WriteLine("1. Mercimek = 25 TL");
									fiyat = 25;
									break;
								case 2:
									Console.WriteLine("2. Ezogelin = 25 TL");
									fiyat = 25;
									break;
								case 3:
									Console.WriteLine("3. Tarhana = 30 TL");
									fiyat = 30;
									break;
								case 4:
									Console.WriteLine("4. Domates = 20 TL");
									fiyat = 20;
									break;
								case 5:
									Console.WriteLine("5. Tavuk = 40 TL");
									fiyat = 40;
									break;
								case 6:
									Console.WriteLine("6. İşkembe = 50 TL");
									fiyat = 50;
									break;
								default:
									Console.WriteLine($"{ad}, bu ürün menümüzde bulunmamakta");
									break;
							}
							Console.WriteLine($"\n{ad}, yanında ekstra bir şey ister misin?\n");
							Console.WriteLine("1. Ekmek\n2. Limon\n");
							Console.WriteLine("Bir şey istemiyorsan lütfen 'h'ye bas");
							string corbaEkstraSecim = Console.ReadLine();
							Console.Clear();
							switch (corbaEkstraSecim)
							{
								case "1":
									Console.WriteLine("Çorabının yanında verilen ekstra ürünler ücrete tabi değildir");
									Console.WriteLine($"{corbaSecim} yanında ekstra {corbaEkstraSecim} seçtin, afiyet olsun.");
									break;
								case "2":
									Console.WriteLine("Çorabının yanında verilen ekstra ürünler ücrete tabi değildir");
									Console.WriteLine($"{corbaSecim} yanında ekstra {corbaEkstraSecim} seçtin, afiyet olsun.");
									break;
							}
							toplam += fiyat;
							almanUsulu[i] = fiyat;
							Console.WriteLine($"{ad}, seçtiğin ürün {corbaSecim}. {fiyat} TL. Toplam {toplam} TL\n");
							break;
						case "meze":
							Console.WriteLine("Meze Menüsü\n");
							Console.WriteLine("1. Haydari = 15 TL");
							Console.WriteLine("2. Humus = 15 TL");
							Console.WriteLine("3. Cacık = 15 TL");
							Console.WriteLine("4. Şakşuka = 15 TL\n");
							Console.WriteLine("Lütfen seçtiğiniz ürünün numarasını girin.");
							Console.WriteLine("Örnek Haydari için '1'");
							int mezeSecim = int.Parse(Console.ReadLine());
							Console.Clear();
							switch (mezeSecim)
							{
								case 1:
									Console.WriteLine("1. Haydari = 15 TL");
									fiyat = 15;
									break;
								case 2:
									Console.WriteLine("2. Humus = 15 TL");
									fiyat = 15;
									break;
								case 3:
									Console.WriteLine("3. Cacık = 15 TL");
									fiyat = 15;
									break;
								case 4:
									Console.WriteLine("4. Şakşuka = 15 TL");
									fiyat = 15;
									break;
								default:
									Console.WriteLine($"{ad}, bu ürün menümüzde bulunmamakta");
									break;
							}
							toplam += fiyat;
							almanUsulu[i] = fiyat;
							Console.WriteLine($"{ad}, seçtiğin ürün {mezeSecim}. {fiyat} TL. Toplam {toplam} TL\n");
							break;
						case "salata":
							Console.WriteLine("Salata Menüsü\n");
							Console.WriteLine("1. Çoban Salata = 30 TL\n");
							int salataSecim = int.Parse(Console.ReadLine());
							Console.Clear();
							switch (salataSecim)
							{
								case 1:
									Console.WriteLine("1. Çoban Salata = 30 TL");
									fiyat = 30;
									break;
								default:
									Console.WriteLine($"{ad}, bu ürün menümüzde bulunmamakta");
									break;
							}
							toplam += fiyat;
							almanUsulu[i] = fiyat;
							Console.WriteLine($"{ad}, seçtiğin ürün {salataSecim}. {fiyat} TL. Toplam {toplam} TL\n");
							break;
						case "tatlı":
							Console.WriteLine("Tatlı Menüsü\n");
							Console.WriteLine("1. Künefe = 75 TL");
							Console.WriteLine("2. Katmer = 75 TL");
							Console.WriteLine("3. Güllaç = 40 TL");
							Console.WriteLine("4. Sütlaç = 40 TL");
							Console.WriteLine("5. Fırın Sütlaç = 45 TL\n");
							Console.WriteLine("Lütfen seçtiğiniz ürünün numarasını girin.");
							Console.WriteLine("Örnek Künefe için '1'");
							int tatliSecim = int.Parse(Console.ReadLine());
							Console.Clear();
							switch (tatliSecim)
							{
								case 1:
									Console.WriteLine("1. Künefe = 75 TL");
									fiyat = 75;
									break;
								case 2:
									Console.WriteLine("2. Katmer = 75 TL");
									fiyat = 75;
									break;
								case 3:
									Console.WriteLine("3. Güllaç = 40 TL");
									fiyat = 40;
									break;
								case 4:
									Console.WriteLine("4. Sütlaç = 40 TL");
									fiyat = 40;
									break;
								case 5:
									Console.WriteLine("5. Fırın Sütlaç = 45 TL");
									fiyat = 45;
									break;
								default:
									Console.WriteLine($"{ad}, bu ürün menümüzde bulunmamakta");
									break;
							}
							Console.WriteLine($"\n{ad}, yanında ekstra bir şey ister misin?\n");
							Console.WriteLine("1. Fındık- 5 TL\n2. Kaymak - 15 TL\n3. Dondurma (1 Top) - 10 TL\n4. Süt - 8 TL\n5. Meyve Tabağı - 25 TL\n");
							Console.WriteLine("Lütfen seçtiğiniz ürünün numarasını girin.");
							Console.WriteLine("Örnek Ekmek için '1'\n");
							Console.WriteLine("Bir şey istemiyorsan lütfen 'h'ye bas");
							string tatliEkstraSecim = Console.ReadLine();
							Console.Clear();
							switch (tatliEkstraSecim)
							{
								case "1":
									Console.WriteLine("1. Fındık- 5 TL");
									tatliEkstraFiyat = 5;
									break;
								case "2":
									Console.WriteLine("2. Kaymak - 15 TL");
									tatliEkstraFiyat = 15;

									break;
								case "3":
									Console.WriteLine("3. Dondurma (1 Top) - 10 TL");
									tatliEkstraFiyat = 10;

									break;
								case "4":
									Console.WriteLine("5. Meyve Tabağı - 25 TL");
									tatliEkstraFiyat = 25;
									break;
							}
							toplam += fiyat;
							almanUsulu[i] = fiyat; ;
							if (tatliEkstraSecim != null)
							{
								toplam += tatliEkstraFiyat;
								Console.WriteLine($"{ad}, seçtiğin ürün {tatliSecim}. {fiyat} TL ve ekstra seçimin {tatliEkstraSecim}. {tatliEkstraFiyat} TL. Toplam {toplam} TL\n");
							}
							else
							{
								Console.WriteLine($"{ad}, seçtiğin ürün {tatliSecim}. {fiyat} TL. Toplam {toplam} TL\n");
							}
							break;
						case "içecek":
							Console.WriteLine("İçecek Menüsü\n");
							Console.WriteLine("1. Kola = 30 TL");
							Console.WriteLine("2. Fanta = 30 TL");
							Console.WriteLine("3. Sprite = 30 TL");
							Console.WriteLine("4. Açık Ayran = 30 TL");
							Console.WriteLine("5. Kapalı Ayran = 25 TL");
							Console.WriteLine("6. Şalgam = 20 TL");
							Console.WriteLine("7. Çay = 10 TL\n");
							Console.WriteLine("Lütfen seçtiğiniz ürünün numarasını girin.");
							Console.WriteLine("Örnek Kola için '1'");
							int icecekSecim = int.Parse(Console.ReadLine());
							Console.Clear();
							switch (icecekSecim)
							{
								case 1:
									Console.WriteLine("1. Kola = 30 TL");
									fiyat = 30;
									break;
								case 2:
									Console.WriteLine("2. Fanta = 30 TL");
									fiyat = 30;
									break;
								case 3:
									Console.WriteLine("3. Sprite = 30 TL");
									fiyat = 30;
									break;
								case 4:
									Console.WriteLine("4. Açık Ayran = 30 TL");
									fiyat = 30;
									break;
								case 5:
									Console.WriteLine("5. Kapalı Ayran = 25 TL");
									fiyat = 25;
									break;
								case 6:
									Console.WriteLine("6. Şalgam = 20 TL");
									fiyat = 20;
									break;
								case 7:
									Console.WriteLine("7. Çay = 10 TL");
									fiyat = 10;
									break;
								default:
									Console.WriteLine($"{ad}, bu ürün menümüzde bulunmamakta");
									break;
							}
							toplam += fiyat;
							almanUsulu[i] = fiyat;
							Console.WriteLine($"{ad}, seçtiğin ürün {icecekSecim}. {fiyat} TL. Toplam {toplam} TL\n");
							break;
						case "ekstra":
							Console.WriteLine("Ekstra Menüsü\n");
							Console.WriteLine("1. Pilav = 25 TL");
							Console.WriteLine("2. Patates Tabağı = 40 TL");
							Console.WriteLine("3. Turşu = 10 TL");
							Console.WriteLine("4. İçli Köfte (tane) = 15 TL");
							Console.WriteLine("5. Çiğköfte (iki kişilik) = 35 TL");
							Console.WriteLine("6. Sarma =  25 TL\n");
							Console.WriteLine("Lütfen seçtiğiniz ürünün numarasını girin.");
							Console.WriteLine("Örnek Kola için '1'");
							int ekstraSecim = int.Parse(Console.ReadLine());
							Console.Clear();
							switch (ekstraSecim)
							{
								case 1:
									Console.WriteLine("1. Pilav = 25 TL");
									fiyat = 25;
									break;
								case 2:
									Console.WriteLine("2. Patates Tabağı = 40 TL");
									fiyat = 40;
									break;
								case 3:
									Console.WriteLine("3. Turşu = 10 TL");
									fiyat = 10;
									break;
								case 4:
									Console.WriteLine("4. İçli Köfte (tane) = 15 TL");
									fiyat = 15;
									break;
								case 5:
									Console.WriteLine("5. Çiğköfte (iki kişilik) = 35 TL");
									fiyat = 35;
									break;
								case 6:
									Console.WriteLine("6. Sarma =  25 TL");
									fiyat = 25;
									break;
								case 7:
									Console.WriteLine("7. Çay = 10 TL");
									fiyat = 10;
									break;
								default:
									Console.WriteLine($"{ad}, bu ürün menümüzde bulunmamakta");
									break;
							}
							toplam += fiyat;
							almanUsulu[i] = fiyat;
							Console.WriteLine($"{ad}, seçtiğin ürün {ekstraSecim}. {fiyat} TL. Toplam {toplam} TL\n");
							break;
						case "x":
							if (i + 1 == kisiSayisi & toplam > 0) //i dizinin indeksine eşitse
																  //kullanıcı sayısıa eşit dersek başarılı çalışmaz
																  //ve toplam 0'dan büyükse kullanıcı hesabı ödemeden gitmesin
							{
								Console.WriteLine("Ödemeniz gereken sipariş bulunmakta, sizi hesap ekranına aktarıyorum.");
								goto case "hesap";
							}
							else
							{
								anaMenuDonme = true; //burada ture verdiğim için aşağıda while'a girer ve false olmadığı
													 //için döngü sonlanır
								Console.WriteLine("Menüden çıktınız");
							}

							break;
						case "hesap":
							Console.WriteLine("1. Hesap Görüntüle\n2. Hesap Öde\n");
							Console.WriteLine("Lütfen yapmak istediğin işlemi gir\n Örnek Hesap görüntülemek için '1'e bas");
							string hesapSecim = Console.ReadLine();
							Console.Clear();
							hesapMenuDonme = false; //hesap görüntüle ödemek ister misinde trueye dönüyor
													//tekrar aynı menüye girmiyor sonrasında
													//bunu önlemek için yazdım
							while (!hesapMenuDonme)
							{
								switch (hesapSecim)
								{
									#region odeme yontemi secme
									case "1":
										Console.WriteLine($"Afiyet olsun, ödemeniz gereken tutar {toplam} TL.\n");
										Console.WriteLine("Hesap ödemek ister misin?");
										Console.WriteLine("Evet için 'e', Hayır için 'h'ye basman yeterli");
										string hesapOdeKarar = Console.ReadLine().ToLower(); ;
										Console.Clear();
										if (hesapOdeKarar == "e")
										{
											Console.WriteLine("Hesap ödeme ekranına yönlendiriyorum...");
											anaMenuDonme = true;
											goto case "2"; //case 2'ye yönlendirme yapar
										}
										else
										{
											anaMenuDonme = false;
											hesapMenuDonme = true;
										}
										break;
									#endregion
									case "2":
										Console.WriteLine($"Toplam fiyat = {toplam}\n");
										Console.WriteLine("Nasıl ödeme yapmak istersiniz?");
										Console.WriteLine("1. Alman usulü\n2. Toplam tutarı kişi sayısına bölerek\n3. Toplam tutarı ödemek");
										string hesapOdemeYontemi = Console.ReadLine();
										Console.Clear();
										double KisiBasiBolme = toplam;
										KisiBasiBolme /= kisiSayisi;
										for (int j = 0; j < kisiSayisi; j++)
										{
											switch (hesapOdemeYontemi)
											{
												case "1":
													Console.WriteLine("1. Alman usulü");
													Console.WriteLine($"Toplam tutar = {toplam}");
													if (j < kisiSayisi || j == kisiSayisi)
													{
														Console.WriteLine($"{j + 1}. Kişi için ödeme tutarı = {almanUsulu[j]}");
														Console.WriteLine("Kaç TL vereceksin?");
														double kullaniciTutar = double.Parse(Console.ReadLine());
														if (almanUsulu[j] == kullaniciTutar || almanUsulu[j] < kullaniciTutar)
														{

															almanUsulu[j] -= kullaniciTutar;
															Console.WriteLine($"Yine bekleriz, işte paraüstü {almanUsulu[j]} TL\n");
															anaMenuDonme = true;
															hesapMenuDonme = true;
														}
														else
														{
															if (j == kisiSayisi || j < kisiSayisi)
															{
																Console.WriteLine("Eksik tutar girdin, seni yeniden ödeme ekranına aktarıyorum...");
																goto case "1";
															}
															System.Threading.Thread.Sleep(1000);
															//console ekranında 1 saniye bekletir
															Console.Clear();
															hesapMenuDonme = false;
														}

													}
													break;
												case "2":
													Console.WriteLine("2. Toplam tutarı kişi sayısına bölerek");
													Console.WriteLine($"Toplam tutar = {toplam}");

													if (j < kisiSayisi || j == kisiSayisi)
													{
														Console.WriteLine($"{j + 1}. Kişi için ödeme tutarı = {KisiBasiBolme}");
														Console.WriteLine("Kaç TL vereceksin?");
														double kullaniciTutar = double.Parse(Console.ReadLine());
														if (KisiBasiBolme == kullaniciTutar || KisiBasiBolme < kullaniciTutar)
														{
															kullaniciTutar -= KisiBasiBolme;
															Console.WriteLine($"Yine bekleriz, işte paraüstü {kullaniciTutar} TL\n");
															anaMenuDonme = true;
															hesapMenuDonme = true;
														}
														else
														{
															if (j == kisiSayisi || j < kisiSayisi)
															{
																Console.WriteLine("Eksik tutar girdin, seni yeniden ödeme ekranına aktarıyorum...");
																goto case "2";
															}
															System.Threading.Thread.Sleep(1000);
															//console ekranında 1 saniye bekletir
															Console.Clear();
															hesapMenuDonme = false;
														}
													}
													break;
												case "3":

													Console.WriteLine("3. Toplam tutarı ödemek");
													Console.WriteLine($"Toplam fiyat = {toplam}\n");
													Console.WriteLine("Kaç TL vereceksin?");
													j = kisiSayisi;
													double kullaniciTutar2 = double.Parse(Console.ReadLine());
													if (toplam == kullaniciTutar2 || toplam < kullaniciTutar2)
													{
														toplam -= kullaniciTutar2;
														Console.WriteLine($"Yine bekleriz, işte paraüstü {toplam} TL\n");
														anaMenuDonme = true;
														hesapMenuDonme = true;
													}
													else
													{
														Console.WriteLine("Eksik tutar girdin, seni yeniden ödeme ekranına aktarıyorum...");
														Console.Clear();
														hesapMenuDonme = false;
													}

													break;
											}
										}
										break;
								}
							}
							break;
					}
				}
				while (!anaMenuDonme);
				//döngüyü sürekli olarak çalıştırır
			}
		}
	}
}
