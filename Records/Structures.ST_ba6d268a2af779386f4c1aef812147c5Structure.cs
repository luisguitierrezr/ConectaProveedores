namespace ssConectaProveedores {
/// <summary>
/// [CustomStructure] Configuration2 (oB1e5oGWtEKAd6uRgjnuzQ)
///  <code>ST_ba6d268a2af779386f4c1aef812147c5Structure</code> that represent
/// s <code>Configuration2</code> <p>Description: </p>
/// </summary>
// Name: Configuration2
public partial struct ST_ba6d268a2af779386f4c1aef812147c5Structure : ITypedRecord<ST_ba6d268a2af779386f4c1aef812147c5Structure> {
internal static readonly GlobalObjectKey Iduserid = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*HdDp3YR51Uipf7ZsAG3DbA");
internal static readonly GlobalObjectKey Idcategoryid = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*p3QvvY6l1EuWvUp4d34ExA");
internal static readonly GlobalObjectKey Idisenabled = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*R30KZD1GUE6oWd+ASHkGGg");
internal static readonly GlobalObjectKey Idnotifybyemail = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*8oaFcEKNOEGMr50CYRIyzA");
internal static readonly GlobalObjectKey Idnotifyinapp = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*gwLN0ua2BEWZ5T5+Fx8UhQ");
internal static readonly GlobalObjectKey Idcategorydescription = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*q5TMd6gS9ESR2oUhzhc8IQ");

public string ssuserid;

public string sscategoryid;

public bool ssisenabled;

public bool ssnotifybyemail;

public bool ssnotifyinapp;

public string sscategorydescription;


public BitArray OptimizedAttributes;

public ST_ba6d268a2af779386f4c1aef812147c5Structure() {
OptimizedAttributes = null;
ssuserid = "";
sscategoryid = "";
ssisenabled = false;
ssnotifybyemail = false;
ssnotifyinapp = false;
sscategorydescription = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssuserid = r.ReadText(index++, "Configuration2.userid", "");
sscategoryid = r.ReadText(index++, "Configuration2.categoryid", "");
ssisenabled = r.ReadBoolean(index++, "Configuration2.isenabled", false);
ssnotifybyemail = r.ReadBoolean(index++, "Configuration2.notifybyemail", false);
ssnotifyinapp = r.ReadBoolean(index++, "Configuration2.notifyinapp", false);
sscategorydescription = r.ReadText(index++, "Configuration2.categorydescription", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_ba6d268a2af779386f4c1aef812147c5Structure r) {
this = r;
}


public static bool operator == (ST_ba6d268a2af779386f4c1aef812147c5Structure a, ST_ba6d268a2af779386f4c1aef812147c5Structure b) {
if (a.ssuserid != b.ssuserid) return false;
if (a.sscategoryid != b.sscategoryid) return false;
if (a.ssisenabled != b.ssisenabled) return false;
if (a.ssnotifybyemail != b.ssnotifybyemail) return false;
if (a.ssnotifyinapp != b.ssnotifyinapp) return false;
if (a.sscategorydescription != b.sscategorydescription) return false;
return true;
}

public static bool operator != (ST_ba6d268a2af779386f4c1aef812147c5Structure a, ST_ba6d268a2af779386f4c1aef812147c5Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_ba6d268a2af779386f4c1aef812147c5Structure)) return false;
return (this == (ST_ba6d268a2af779386f4c1aef812147c5Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssuserid.GetHashCode()
 ^ sscategoryid.GetHashCode()
 ^ ssisenabled.GetHashCode()
 ^ ssnotifybyemail.GetHashCode()
 ^ ssnotifyinapp.GetHashCode()
 ^ sscategorydescription.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_ba6d268a2af779386f4c1aef812147c5Structure Duplicate() {
ST_ba6d268a2af779386f4c1aef812147c5Structure t;
t.ssuserid = this.ssuserid;
t.sscategoryid = this.sscategoryid;
t.ssisenabled = this.ssisenabled;
t.ssnotifybyemail = this.ssnotifybyemail;
t.ssnotifyinapp = this.ssnotifyinapp;
t.sscategorydescription = this.sscategorydescription;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "userid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".userid")) variable.Value = ssuserid; else variable.Optimized = true;
} else if (head == "categoryid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".categoryid")) variable.Value = sscategoryid; else variable.Optimized = true;
} else if (head == "isenabled") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".isenabled")) variable.Value = ssisenabled; else variable.Optimized = true;
} else if (head == "notifybyemail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".notifybyemail")) variable.Value = ssnotifybyemail; else variable.Optimized = true;
} else if (head == "notifyinapp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".notifyinapp")) variable.Value = ssnotifyinapp; else variable.Optimized = true;
} else if (head == "categorydescription") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".categorydescription")) variable.Value = sscategorydescription; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == Iduserid) {
return ssuserid;
}
if (key == Idcategoryid) {
return sscategoryid;
}
if (key == Idisenabled) {
return ssisenabled;
}
if (key == Idnotifybyemail) {
return ssnotifybyemail;
}
if (key == Idnotifyinapp) {
return ssnotifyinapp;
}
if (key == Idcategorydescription) {
return sscategorydescription;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Iduserid.Key.AsGuid) {
return ssuserid;
}
if (attributeKey == Idcategoryid.Key.AsGuid) {
return sscategoryid;
}
if (attributeKey == Idisenabled.Key.AsGuid) {
return ssisenabled;
}
if (attributeKey == Idnotifybyemail.Key.AsGuid) {
return ssnotifybyemail;
}
if (attributeKey == Idnotifyinapp.Key.AsGuid) {
return ssnotifyinapp;
}
if (attributeKey == Idcategorydescription.Key.AsGuid) {
return sscategorydescription;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssuserid = (string) other.AttributeGet(Iduserid);
sscategoryid = (string) other.AttributeGet(Idcategoryid);
ssisenabled = (bool) other.AttributeGet(Idisenabled);
ssnotifybyemail = (bool) other.AttributeGet(Idnotifybyemail);
ssnotifyinapp = (bool) other.AttributeGet(Idnotifyinapp);
sscategorydescription = (string) other.AttributeGet(Idcategorydescription);
}
} // ST_ba6d268a2af779386f4c1aef812147c5Structure
/// <summary>
/// RecordList type <code>Configuration2List</code> that represents a record list of
///  <code>Configuration2</code>
/// </summary>
public partial class RL_3ff9916e5a2a5558f61f2a757294606e : GenericRecordList<ST_ba6d268a2af779386f4c1aef812147c5Structure>, IEnumerable, IEnumerator {

protected override ST_ba6d268a2af779386f4c1aef812147c5Structure GetElementDefaultValue() {
return new ST_ba6d268a2af779386f4c1aef812147c5Structure();
}

public T[] ToArray<T>(Func<ST_ba6d268a2af779386f4c1aef812147c5Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3ff9916e5a2a5558f61f2a757294606e recordList, Func<ST_ba6d268a2af779386f4c1aef812147c5Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3ff9916e5a2a5558f61f2a757294606e(ST_ba6d268a2af779386f4c1aef812147c5Structure[] array) {
  RL_3ff9916e5a2a5558f61f2a757294606e result = new RL_3ff9916e5a2a5558f61f2a757294606e();
result.InnerFromArray(array);
    return result;
}

public static RL_3ff9916e5a2a5558f61f2a757294606e ToList<T>(T[] array, Func <T, ST_ba6d268a2af779386f4c1aef812147c5Structure> converter) {
  RL_3ff9916e5a2a5558f61f2a757294606e result = new RL_3ff9916e5a2a5558f61f2a757294606e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3ff9916e5a2a5558f61f2a757294606e FromRestList<T>(RestList<T> restList, Func <T, ST_ba6d268a2af779386f4c1aef812147c5Structure> converter) {
  RL_3ff9916e5a2a5558f61f2a757294606e result = new RL_3ff9916e5a2a5558f61f2a757294606e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3ff9916e5a2a5558f61f2a757294606e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_ba6d268a2af779386f4c1aef812147c5Structure> NewList() {
return new RL_3ff9916e5a2a5558f61f2a757294606e();
}


} // RL_3ff9916e5a2a5558f61f2a757294606e
}


namespace ssConectaProveedores {
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Abstractions;
public class RESTConfiguration2 {
[JsonProperty("userid")]
public string restuserid;

[JsonProperty("categoryid")]
public string restcategoryid;

[JsonProperty("isenabled")]
public bool? restisenabled;

[JsonProperty("notifybyemail")]
public bool? restnotifybyemail;

[JsonProperty("notifyinapp")]
public bool? restnotifyinapp;

[JsonProperty("categorydescription")]
public string restcategorydescription;

public RESTConfiguration2() { }

public RESTConfiguration2(ST_ba6d268a2af779386f4c1aef812147c5Structure s) {
restuserid = s.ssuserid;
restcategoryid = s.sscategoryid;
restisenabled = s.ssisenabled == false ? null : (bool?) s.ssisenabled;
restnotifybyemail = s.ssnotifybyemail == false ? null : (bool?) s.ssnotifybyemail;
restnotifyinapp = s.ssnotifyinapp == false ? null : (bool?) s.ssnotifyinapp;
restcategorydescription = s.sscategorydescription == "" ? null : s.sscategorydescription;
}

public static ST_ba6d268a2af779386f4c1aef812147c5Structure ToStructure(RESTConfiguration2 obj) { 
  ST_ba6d268a2af779386f4c1aef812147c5Structure s = new ST_ba6d268a2af779386f4c1aef812147c5Structure();
  if(obj != null) {
  s.ssuserid = obj.restuserid == null ? "" : obj.restuserid;
  s.sscategoryid = obj.restcategoryid == null ? "" : obj.restcategoryid;
  s.ssisenabled = obj.restisenabled == null ? false : obj.restisenabled.Value;
  s.ssnotifybyemail = obj.restnotifybyemail == null ? false : obj.restnotifybyemail.Value;
  s.ssnotifyinapp = obj.restnotifyinapp == null ? false : obj.restnotifyinapp.Value;
  s.sscategorydescription = obj.restcategorydescription == null ? "" : obj.restcategorydescription;
  }
  return s;
}

public static RESTConfiguration2 FromStructure(ST_ba6d268a2af779386f4c1aef812147c5Structure s) { 
  return new RESTConfiguration2(s);
}

}
}
