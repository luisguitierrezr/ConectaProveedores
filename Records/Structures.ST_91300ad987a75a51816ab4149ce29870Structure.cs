namespace ssConectaProveedores {
/// <summary>
/// [CustomStructure] dataoutput2 (VYaJYIdPcECcBDvjQINe4g)
///  <code>ST_91300ad987a75a51816ab4149ce29870Structure</code> that represents <code>dataoutput2</code
/// > <p>Description: </p>
/// </summary>
// Name: dataoutput2
public partial struct ST_91300ad987a75a51816ab4149ce29870Structure : ITypedRecord<ST_91300ad987a75a51816ab4149ce29870Structure> {
internal static readonly GlobalObjectKey Idnotificationlist = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*Y8xE9cyzRE6m4Z_KDmb5lQ");
internal static readonly GlobalObjectKey Idconfigurationlist = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*oLjV1jkelkOng5CnShspnA");
internal static readonly GlobalObjectKey Idcheckedusers = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*NCZTGjffh0KtbpMUI19+EQ");

public RL_02b33a244546a7f09e6ac2e1170aaea2 ssnotificationlist;

public RL_3ff9916e5a2a5558f61f2a757294606e ssconfigurationlist;

public ST_06cbd1286b150e2e79c91e9d1ed3d811Structure sscheckedusers;


public BitArray OptimizedAttributes;

public ST_91300ad987a75a51816ab4149ce29870Structure() {
OptimizedAttributes = null;
ssnotificationlist = new RL_02b33a244546a7f09e6ac2e1170aaea2();
ssconfigurationlist = new RL_3ff9916e5a2a5558f61f2a757294606e();
sscheckedusers = new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    sscheckedusers.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(ST_91300ad987a75a51816ab4149ce29870Structure r) {
this = r;
}


public static bool operator == (ST_91300ad987a75a51816ab4149ce29870Structure a, ST_91300ad987a75a51816ab4149ce29870Structure b) {
if (a.ssnotificationlist != b.ssnotificationlist) return false;
if (a.ssconfigurationlist != b.ssconfigurationlist) return false;
if (a.sscheckedusers != b.sscheckedusers) return false;
return true;
}

public static bool operator != (ST_91300ad987a75a51816ab4149ce29870Structure a, ST_91300ad987a75a51816ab4149ce29870Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_91300ad987a75a51816ab4149ce29870Structure)) return false;
return (this == (ST_91300ad987a75a51816ab4149ce29870Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssnotificationlist.GetHashCode()
 ^ ssconfigurationlist.GetHashCode()
 ^ sscheckedusers.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssnotificationlist.RecursiveReset();
ssconfigurationlist.RecursiveReset();
sscheckedusers.RecursiveReset();
}

public void InternalRecursiveSave() {
ssnotificationlist.InternalRecursiveSave();
ssconfigurationlist.InternalRecursiveSave();
sscheckedusers.InternalRecursiveSave();
}


public ST_91300ad987a75a51816ab4149ce29870Structure Duplicate() {
ST_91300ad987a75a51816ab4149ce29870Structure t;
t.ssnotificationlist = (RL_02b33a244546a7f09e6ac2e1170aaea2)this.ssnotificationlist.Duplicate();
t.ssconfigurationlist = (RL_3ff9916e5a2a5558f61f2a757294606e)this.ssconfigurationlist.Duplicate();
t.sscheckedusers = (ST_06cbd1286b150e2e79c91e9d1ed3d811Structure)this.sscheckedusers.Duplicate();
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
if (head == "notificationlist") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".notificationlist")) variable.Value = ssnotificationlist; else variable.Optimized = true;
variable.SetFieldName("notificationlist");
} else if (head == "configurationlist") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".configurationlist")) variable.Value = ssconfigurationlist; else variable.Optimized = true;
variable.SetFieldName("configurationlist");
} else if (head == "checkedusers") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".checkedusers")) variable.Value = sscheckedusers; else variable.Optimized = true;
variable.SetFieldName("checkedusers");
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
if (key == Idnotificationlist) {
return ssnotificationlist;
}
if (key == Idconfigurationlist) {
return ssconfigurationlist;
}
if (key == Idcheckedusers) {
return sscheckedusers;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idnotificationlist.Key.AsGuid) {
return ssnotificationlist;
}
if (attributeKey == Idconfigurationlist.Key.AsGuid) {
return ssconfigurationlist;
}
if (attributeKey == Idcheckedusers.Key.AsGuid) {
return sscheckedusers;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssnotificationlist = new RL_02b33a244546a7f09e6ac2e1170aaea2();
ssnotificationlist.FillFromOther((IOSList) other.AttributeGet(Idnotificationlist));
ssconfigurationlist = new RL_3ff9916e5a2a5558f61f2a757294606e();
ssconfigurationlist.FillFromOther((IOSList) other.AttributeGet(Idconfigurationlist));
sscheckedusers.FillFromOther((IRecord) other.AttributeGet(Idcheckedusers));
}
} // ST_91300ad987a75a51816ab4149ce29870Structure
/// <summary>
/// RecordList type <code>dataoutput2List</code> that represents a record list of
///  <code>dataoutput2</code>
/// </summary>
public partial class RL_054f6d3e8558ebfb12b22e9eb8c51533 : GenericRecordList<ST_91300ad987a75a51816ab4149ce29870Structure>, IEnumerable, IEnumerator {

protected override ST_91300ad987a75a51816ab4149ce29870Structure GetElementDefaultValue() {
return new ST_91300ad987a75a51816ab4149ce29870Structure();
}

public T[] ToArray<T>(Func<ST_91300ad987a75a51816ab4149ce29870Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_054f6d3e8558ebfb12b22e9eb8c51533 recordList, Func<ST_91300ad987a75a51816ab4149ce29870Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_054f6d3e8558ebfb12b22e9eb8c51533(ST_91300ad987a75a51816ab4149ce29870Structure[] array) {
  RL_054f6d3e8558ebfb12b22e9eb8c51533 result = new RL_054f6d3e8558ebfb12b22e9eb8c51533();
result.InnerFromArray(array);
    return result;
}

public static RL_054f6d3e8558ebfb12b22e9eb8c51533 ToList<T>(T[] array, Func <T, ST_91300ad987a75a51816ab4149ce29870Structure> converter) {
  RL_054f6d3e8558ebfb12b22e9eb8c51533 result = new RL_054f6d3e8558ebfb12b22e9eb8c51533();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_054f6d3e8558ebfb12b22e9eb8c51533 FromRestList<T>(RestList<T> restList, Func <T, ST_91300ad987a75a51816ab4149ce29870Structure> converter) {
  RL_054f6d3e8558ebfb12b22e9eb8c51533 result = new RL_054f6d3e8558ebfb12b22e9eb8c51533();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_054f6d3e8558ebfb12b22e9eb8c51533() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_91300ad987a75a51816ab4149ce29870Structure> NewList() {
return new RL_054f6d3e8558ebfb12b22e9eb8c51533();
}


} // RL_054f6d3e8558ebfb12b22e9eb8c51533
}


namespace ssConectaProveedores {
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Abstractions;
public class RESTdataoutput2 {
[JsonProperty("notificationlist")]
public RESTNotificationOutput2[] restnotificationlist;

[JsonProperty("configurationlist")]
public RESTConfiguration2[] restconfigurationlist;

[JsonProperty("checkedusers")]
public RESTusers2 restcheckedusers;

public RESTdataoutput2() { }

public RESTdataoutput2(ST_91300ad987a75a51816ab4149ce29870Structure s) {
restnotificationlist = s.ssnotificationlist.Length == 0 ? null : s.ssnotificationlist.ToArray<RESTNotificationOutput2>(RESTNotificationOutput2.FromStructure);
restconfigurationlist = s.ssconfigurationlist.Length == 0 ? null : s.ssconfigurationlist.ToArray<RESTConfiguration2>(RESTConfiguration2.FromStructure);
restcheckedusers = new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure().Equals((ST_06cbd1286b150e2e79c91e9d1ed3d811Structure)s.sscheckedusers) ? null : RESTusers2.FromStructure(s.sscheckedusers);
}

public static ST_91300ad987a75a51816ab4149ce29870Structure ToStructure(RESTdataoutput2 obj) { 
  ST_91300ad987a75a51816ab4149ce29870Structure s = new ST_91300ad987a75a51816ab4149ce29870Structure();
  if(obj != null) {
  s.ssnotificationlist = RL_02b33a244546a7f09e6ac2e1170aaea2.ToList(obj.restnotificationlist, RESTNotificationOutput2.ToStructure);
  s.ssconfigurationlist = RL_3ff9916e5a2a5558f61f2a757294606e.ToList(obj.restconfigurationlist, RESTConfiguration2.ToStructure);
  s.sscheckedusers = RESTusers2.ToStructure(obj.restcheckedusers);
  }
  return s;
}

public static RESTdataoutput2 FromStructure(ST_91300ad987a75a51816ab4149ce29870Structure s) { 
  return new RESTdataoutput2(s);
}

}
}
