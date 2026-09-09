namespace ssConectaProveedores {
/// <summary>
/// [CustomStructure] users2 (tQ0RnRZACUatY8kEvoGPfw)
///  <code>ST_06cbd1286b150e2e79c91e9d1ed3d811Structure</code> that represents <code>users2</code
/// > <p>Description: </p>
/// </summary>
// Name: users2
public partial struct ST_06cbd1286b150e2e79c91e9d1ed3d811Structure : ITypedRecord<ST_06cbd1286b150e2e79c91e9d1ed3d811Structure> {
internal static readonly GlobalObjectKey Idliststring = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*QHrwKw3Dl0utNF1p7o_zNw");
internal static readonly GlobalObjectKey Idcategoryclass = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PYAhCpMGTUyvkVOrNb9CVw");

public string ssliststring;

public string sscategoryclass;


public BitArray OptimizedAttributes;

public ST_06cbd1286b150e2e79c91e9d1ed3d811Structure() {
OptimizedAttributes = null;
ssliststring = "";
sscategoryclass = "";
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
ssliststring = r.ReadText(index++, "users2.liststring", "");
sscategoryclass = r.ReadText(index++, "users2.categoryclass", "");
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
public void ReadIM(ST_06cbd1286b150e2e79c91e9d1ed3d811Structure r) {
this = r;
}


public static bool operator == (ST_06cbd1286b150e2e79c91e9d1ed3d811Structure a, ST_06cbd1286b150e2e79c91e9d1ed3d811Structure b) {
if (a.ssliststring != b.ssliststring) return false;
if (a.sscategoryclass != b.sscategoryclass) return false;
return true;
}

public static bool operator != (ST_06cbd1286b150e2e79c91e9d1ed3d811Structure a, ST_06cbd1286b150e2e79c91e9d1ed3d811Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_06cbd1286b150e2e79c91e9d1ed3d811Structure)) return false;
return (this == (ST_06cbd1286b150e2e79c91e9d1ed3d811Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssliststring.GetHashCode()
 ^ sscategoryclass.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_06cbd1286b150e2e79c91e9d1ed3d811Structure Duplicate() {
ST_06cbd1286b150e2e79c91e9d1ed3d811Structure t;
t.ssliststring = this.ssliststring;
t.sscategoryclass = this.sscategoryclass;
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
if (head == "liststring") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".liststring")) variable.Value = ssliststring; else variable.Optimized = true;
} else if (head == "categoryclass") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".categoryclass")) variable.Value = sscategoryclass; else variable.Optimized = true;
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
if (key == Idliststring) {
return ssliststring;
}
if (key == Idcategoryclass) {
return sscategoryclass;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idliststring.Key.AsGuid) {
return ssliststring;
}
if (attributeKey == Idcategoryclass.Key.AsGuid) {
return sscategoryclass;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssliststring = (string) other.AttributeGet(Idliststring);
sscategoryclass = (string) other.AttributeGet(Idcategoryclass);
}
} // ST_06cbd1286b150e2e79c91e9d1ed3d811Structure
/// <summary>
/// RecordList type <code>users2List</code> that represents a record list of <code>users2</code>
/// </summary>
public partial class RL_68f6f2d584b20e40d15bc6bea5e4939e : GenericRecordList<ST_06cbd1286b150e2e79c91e9d1ed3d811Structure>, IEnumerable, IEnumerator {

protected override ST_06cbd1286b150e2e79c91e9d1ed3d811Structure GetElementDefaultValue() {
return new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure();
}

public T[] ToArray<T>(Func<ST_06cbd1286b150e2e79c91e9d1ed3d811Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_68f6f2d584b20e40d15bc6bea5e4939e recordList, Func<ST_06cbd1286b150e2e79c91e9d1ed3d811Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_68f6f2d584b20e40d15bc6bea5e4939e(ST_06cbd1286b150e2e79c91e9d1ed3d811Structure[] array) {
  RL_68f6f2d584b20e40d15bc6bea5e4939e result = new RL_68f6f2d584b20e40d15bc6bea5e4939e();
result.InnerFromArray(array);
    return result;
}

public static RL_68f6f2d584b20e40d15bc6bea5e4939e ToList<T>(T[] array, Func <T, ST_06cbd1286b150e2e79c91e9d1ed3d811Structure> converter) {
  RL_68f6f2d584b20e40d15bc6bea5e4939e result = new RL_68f6f2d584b20e40d15bc6bea5e4939e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_68f6f2d584b20e40d15bc6bea5e4939e FromRestList<T>(RestList<T> restList, Func <T, ST_06cbd1286b150e2e79c91e9d1ed3d811Structure> converter) {
  RL_68f6f2d584b20e40d15bc6bea5e4939e result = new RL_68f6f2d584b20e40d15bc6bea5e4939e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_68f6f2d584b20e40d15bc6bea5e4939e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_06cbd1286b150e2e79c91e9d1ed3d811Structure> NewList() {
return new RL_68f6f2d584b20e40d15bc6bea5e4939e();
}


} // RL_68f6f2d584b20e40d15bc6bea5e4939e
}


namespace ssConectaProveedores {
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Abstractions;
public class RESTusers2 {
[JsonProperty("liststring")]
public string restliststring;

[JsonProperty("categoryclass")]
public string restcategoryclass;

public RESTusers2() { }

public RESTusers2(ST_06cbd1286b150e2e79c91e9d1ed3d811Structure s) {
restliststring = s.ssliststring == "" ? null : s.ssliststring;
restcategoryclass = s.sscategoryclass;
}

public static ST_06cbd1286b150e2e79c91e9d1ed3d811Structure ToStructure(RESTusers2 obj) { 
  ST_06cbd1286b150e2e79c91e9d1ed3d811Structure s = new ST_06cbd1286b150e2e79c91e9d1ed3d811Structure();
  if(obj != null) {
  s.ssliststring = obj.restliststring == null ? "" : obj.restliststring;
  s.sscategoryclass = obj.restcategoryclass == null ? "" : obj.restcategoryclass;
  }
  return s;
}

public static RESTusers2 FromStructure(ST_06cbd1286b150e2e79c91e9d1ed3d811Structure s) { 
  return new RESTusers2(s);
}

}
}
