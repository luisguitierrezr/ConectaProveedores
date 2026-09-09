namespace ssConectaProveedores {
/// <summary>
/// [CustomStructure] APIOutput2 (+oM6V6+uVEeSkb+p1atb3w)
///  <code>ST_8509a484f6b6eac99c83feddd35d5004Structure</code> that represents <code>APIOutput2</code
/// > <p>Description: </p>
/// </summary>
// Name: APIOutput2
public partial struct ST_8509a484f6b6eac99c83feddd35d5004Structure : ITypedRecord<ST_8509a484f6b6eac99c83feddd35d5004Structure> {
internal static readonly GlobalObjectKey Idsuccess = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PPKk4mj7p0yHbP5QEhiTLQ");
internal static readonly GlobalObjectKey Iderrors = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*0KST8DY7UUWTJkElgHRf4g");
internal static readonly GlobalObjectKey Iddata = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*eG8gXcWLKEi7IO7ZySq7yw");

public bool sssuccess;

public string sserrors;

public ST_91300ad987a75a51816ab4149ce29870Structure ssdata;


public BitArray OptimizedAttributes;

public ST_8509a484f6b6eac99c83feddd35d5004Structure() {
OptimizedAttributes = null;
sssuccess = false;
sserrors = "";
ssdata = new ST_91300ad987a75a51816ab4149ce29870Structure();
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
    ssdata.OptimizedAttributes = value[0];
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
sssuccess = r.ReadBoolean(index++, "APIOutput2.success", false);
sserrors = r.ReadText(index++, "APIOutput2.errors", "");
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
public void ReadIM(ST_8509a484f6b6eac99c83feddd35d5004Structure r) {
this = r;
}


public static bool operator == (ST_8509a484f6b6eac99c83feddd35d5004Structure a, ST_8509a484f6b6eac99c83feddd35d5004Structure b) {
if (a.sssuccess != b.sssuccess) return false;
if (a.sserrors != b.sserrors) return false;
if (a.ssdata != b.ssdata) return false;
return true;
}

public static bool operator != (ST_8509a484f6b6eac99c83feddd35d5004Structure a, ST_8509a484f6b6eac99c83feddd35d5004Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_8509a484f6b6eac99c83feddd35d5004Structure)) return false;
return (this == (ST_8509a484f6b6eac99c83feddd35d5004Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ sssuccess.GetHashCode()
 ^ sserrors.GetHashCode()
 ^ ssdata.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssdata.RecursiveReset();
}

public void InternalRecursiveSave() {
ssdata.InternalRecursiveSave();
}


public ST_8509a484f6b6eac99c83feddd35d5004Structure Duplicate() {
ST_8509a484f6b6eac99c83feddd35d5004Structure t;
t.sssuccess = this.sssuccess;
t.sserrors = this.sserrors;
t.ssdata = (ST_91300ad987a75a51816ab4149ce29870Structure)this.ssdata.Duplicate();
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
if (head == "success") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".success")) variable.Value = sssuccess; else variable.Optimized = true;
} else if (head == "errors") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".errors")) variable.Value = sserrors; else variable.Optimized = true;
} else if (head == "data") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".data")) variable.Value = ssdata; else variable.Optimized = true;
variable.SetFieldName("data");
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
if (key == Idsuccess) {
return sssuccess;
}
if (key == Iderrors) {
return sserrors;
}
if (key == Iddata) {
return ssdata;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idsuccess.Key.AsGuid) {
return sssuccess;
}
if (attributeKey == Iderrors.Key.AsGuid) {
return sserrors;
}
if (attributeKey == Iddata.Key.AsGuid) {
return ssdata;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
sssuccess = (bool) other.AttributeGet(Idsuccess);
sserrors = (string) other.AttributeGet(Iderrors);
ssdata.FillFromOther((IRecord) other.AttributeGet(Iddata));
}
} // ST_8509a484f6b6eac99c83feddd35d5004Structure
/// <summary>
/// RecordList type <code>APIOutput2List</code> that represents a record list of
///  <code>APIOutput2</code>
/// </summary>
public partial class RL_807ce30552f5c62962868cb7d22ab2a3 : GenericRecordList<ST_8509a484f6b6eac99c83feddd35d5004Structure>, IEnumerable, IEnumerator {

protected override ST_8509a484f6b6eac99c83feddd35d5004Structure GetElementDefaultValue() {
return new ST_8509a484f6b6eac99c83feddd35d5004Structure();
}

public T[] ToArray<T>(Func<ST_8509a484f6b6eac99c83feddd35d5004Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_807ce30552f5c62962868cb7d22ab2a3 recordList, Func<ST_8509a484f6b6eac99c83feddd35d5004Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_807ce30552f5c62962868cb7d22ab2a3(ST_8509a484f6b6eac99c83feddd35d5004Structure[] array) {
  RL_807ce30552f5c62962868cb7d22ab2a3 result = new RL_807ce30552f5c62962868cb7d22ab2a3();
result.InnerFromArray(array);
    return result;
}

public static RL_807ce30552f5c62962868cb7d22ab2a3 ToList<T>(T[] array, Func <T, ST_8509a484f6b6eac99c83feddd35d5004Structure> converter) {
  RL_807ce30552f5c62962868cb7d22ab2a3 result = new RL_807ce30552f5c62962868cb7d22ab2a3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_807ce30552f5c62962868cb7d22ab2a3 FromRestList<T>(RestList<T> restList, Func <T, ST_8509a484f6b6eac99c83feddd35d5004Structure> converter) {
  RL_807ce30552f5c62962868cb7d22ab2a3 result = new RL_807ce30552f5c62962868cb7d22ab2a3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_807ce30552f5c62962868cb7d22ab2a3() : base() {
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
protected override OSList<ST_8509a484f6b6eac99c83feddd35d5004Structure> NewList() {
return new RL_807ce30552f5c62962868cb7d22ab2a3();
}


} // RL_807ce30552f5c62962868cb7d22ab2a3
}


namespace ssConectaProveedores {
using OutSystems.RESTService;
using OutSystems.RESTService.Runtime.Abstractions;
public class RESTAPIOutput2 {
[JsonProperty("success")]
public bool? restsuccess;

[JsonProperty("errors")]
public string resterrors;

[JsonProperty("data")]
public RESTdataoutput2 restdata;

public RESTAPIOutput2() { }

public RESTAPIOutput2(ST_8509a484f6b6eac99c83feddd35d5004Structure s) {
restsuccess = s.sssuccess == false ? null : (bool?) s.sssuccess;
resterrors = s.sserrors == "" ? null : s.sserrors;
restdata = new ST_91300ad987a75a51816ab4149ce29870Structure().Equals((ST_91300ad987a75a51816ab4149ce29870Structure)s.ssdata) ? null : RESTdataoutput2.FromStructure(s.ssdata);
}

public static ST_8509a484f6b6eac99c83feddd35d5004Structure ToStructure(RESTAPIOutput2 obj) { 
  ST_8509a484f6b6eac99c83feddd35d5004Structure s = new ST_8509a484f6b6eac99c83feddd35d5004Structure();
  if(obj != null) {
  s.sssuccess = obj.restsuccess == null ? false : obj.restsuccess.Value;
  s.sserrors = obj.resterrors == null ? "" : obj.resterrors;
  s.ssdata = RESTdataoutput2.ToStructure(obj.restdata);
  }
  return s;
}

public static RESTAPIOutput2 FromStructure(ST_8509a484f6b6eac99c83feddd35d5004Structure s) { 
  return new RESTAPIOutput2(s);
}

}
}
