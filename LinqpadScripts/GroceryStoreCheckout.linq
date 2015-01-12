<Query Kind="Program">
  <Connection>
    <ID>d5a07c7b-4200-420a-93ab-5a2b823b70b2</ID>
    <Server>and-test4</Server>
    <Database>Office365Security.Prod</Database>
    <ShowServer>true</ShowServer>
  </Connection>
</Query>

void Main()
{
//	  A     50       3 for 130
//    B     30       2 for 45
//    C     20
//    D     15
	var rules = new List<Rule>(){
									new Rule('A', 50, new Tuple<int, int>(3, 130)),
									new Rule('B', 30, new Tuple<int, int>(2, 45)),
									new Rule('C', 20),
									new Rule('D', 15),
								};
//	rules.Dump();
	Price(rules, "").Dump();
	Price(rules, "A").Dump();
	Price(rules, "AB").Dump();
//	//assert_equal(115, price("CDBA"))
	Price(rules, "CDBA").Dump();
////	assert_equal(100, price("AA"))
	Price(rules, "AA").Dump();

//    assert_equal(130, price("AAA"))
	Price(rules, "AAA").Dump();
////    assert_equal(180, price("AAAA"))
	Price(rules, "AAAA").Dump();
////    assert_equal(230, price("AAAAA"))
	Price(rules, "AAAAA").Dump();
//    assert_equal(260, price("AAAAAA"))
	Price(rules, "AAAAAA").Dump();
//
//    assert_equal(160, price("AAAB"))
	Price(rules, "AAAB").Dump();
//    assert_equal(175, price("AAABB"))
	Price(rules, "AAABB").Dump();
//    assert_equal(190, price("AAABBD"))
	Price(rules, "AAABBD").Dump();
//    assert_equal(190, price("DABABA"))
	Price(rules, "DABABA").Dump();
}

public int Price(List<Rule> rules, string goods) {
	var co = CheckOut.New(rules);
	var goodList = goods.ToCharArray();
	foreach(var good in goodList){
		co.Scan(good);
	}
	
	return co.Total();
}

public class CheckOut {
	private static List<Rule> rules;
	public static CheckOut New(List<Rule> rules){
		CheckOut.rules = rules;
		return new CheckOut();
	}
	
	int total = 0;
	Dictionary<char, int> CountOfItemsBought;
	public CheckOut(){
		CountOfItemsBought = new Dictionary<char, int>();
	}
	
	public void Scan(char item){
		// TODO
		
		// if item in rules with special price list
		Rule itemPrice = rules.Where<Rule>(x => x.Item == item).FirstOrDefault();
		if(itemPrice.Specials == null || CountOfItemsBought.ContainsKey(item) == false){
			total += itemPrice.UnitPrice;
			CountOfItemsBought.Add(item, 1);
			return;
		}
		
		int modVal = ((CountOfItemsBought[item] + 1) % itemPrice.Specials.Item1);//.Dump();
//		int specialsCount = ((CountOfItemsBought[item] + 1) / itemPrice.Specials.Item1);
		
		if(modVal == 0) {
			//subtract regular proce
//			total.Dump("1");
			total = total - 
								((itemPrice.Specials.Item1 - 1) * itemPrice.UnitPrice)//.Dump("Sub")
								+ (itemPrice.Specials.Item2);//.Dump("Add");
//			total.Dump("2");
		} else {
			total += itemPrice.UnitPrice;
		}
		
		CountOfItemsBought[item]++;//.Dump();
		// then check if appropriate amounts were bought
						// if yes then special price
						// if no then return regular price
		// else return regular price
	}
	
	public int Total(){
		return total;
	}
}

// Define other methods and classes here
public class Rule {
	public char Item { get; private set; }
	public int UnitPrice { get; private set; }
	public Tuple<int, int> Specials { get; private set; }
	public Rule(char item, int unitPrice) : this(item, unitPrice, null) {
		
	}
	public Rule(char item, int unitPrice, Tuple<int, int> specials) {
		this.Item = item;
		this.UnitPrice = unitPrice;
		this.Specials = specials;
	}
}