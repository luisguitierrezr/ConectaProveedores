namespace ssConectaProveedores {
/// <summary>
/// [CustomStructure] URLQueryParameter (9vGKiS7cwEC1BZAXRVtKpQ)
///  <code>ST_f9be77c0ae9485d53ded05b1557548f9Structure</code> that represent
/// s <code>URLQueryParameter</code> <p>Description: </p>
/// </summary>
// Name: URLQueryParameter
public partial struct ST_f9be77c0ae9485d53ded05b1557548f9Structure : ITypedRecord<ST_f9be77c0ae9485d53ded05b1557548f9Structure> {
internal static readonly GlobalObjectKey IdName = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*+HH3o0WlxkW5GQmODpaLIw");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("6dONWMH_kUW9Ti9X5sMIKA*PNhJsuiaj0GjFLHmysSSEQ");

public string ssName;

public string ssValue;


public BitArray OptimizedAttributes;

public ST_f9be77c0ae9485d53ded05b1557548f9Structure() {
OptimizedAttributes = null;
ssName = "";
ssValue = "";
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
ssName = r.ReadText(index++, "URLQueryParameter.Name", "");
ssValue = r.ReadText(index++, "URLQueryParameter.Value", "");
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
public void ReadIM(ST_f9be77c0ae9485d53ded05b1557548f9Structure r) {
this = r;
}


public static bool operator == (ST_f9be77c0ae9485d53ded05b1557548f9Structure a, ST_f9be77c0ae9485d53ded05b1557548f9Structure b) {
if (a.ssName != b.ssName) return false;
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (ST_f9be77c0ae9485d53ded05b1557548f9Structure a, ST_f9be77c0ae9485d53ded05b1557548f9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_f9be77c0ae9485d53ded05b1557548f9Structure)) return false;
return (this == (ST_f9be77c0ae9485d53ded05b1557548f9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssName.GetHashCode()
 ^ ssValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_f9be77c0ae9485d53ded05b1557548f9Structure Duplicate() {
ST_f9be77c0ae9485d53ded05b1557548f9Structure t;
t.ssName = this.ssName;
t.ssValue = this.ssValue;
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
if (head == "name") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Name")) variable.Value = ssName; else variable.Optimized = true;
} else if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
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
if (key == IdName) {
return ssName;
}
if (key == IdValue) {
return ssValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdName.Key.AsGuid) {
return ssName;
}
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssName = (string) other.AttributeGet(IdName);
ssValue = (string) other.AttributeGet(IdValue);
}
} // ST_f9be77c0ae9485d53ded05b1557548f9Structure
/// <summary>
/// RecordList type <code>URLQueryParameterList</code> that represents a record list of
///  <code>URLQueryParameter</code>
/// </summary>
public partial class RL_09d38ca4875adba9fe0bf71f298f1c3d : GenericRecordList<ST_f9be77c0ae9485d53ded05b1557548f9Structure>, IEnumerable, IEnumerator {

protected override ST_f9be77c0ae9485d53ded05b1557548f9Structure GetElementDefaultValue() {
return new ST_f9be77c0ae9485d53ded05b1557548f9Structure();
}

public T[] ToArray<T>(Func<ST_f9be77c0ae9485d53ded05b1557548f9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_09d38ca4875adba9fe0bf71f298f1c3d recordList, Func<ST_f9be77c0ae9485d53ded05b1557548f9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_09d38ca4875adba9fe0bf71f298f1c3d(ST_f9be77c0ae9485d53ded05b1557548f9Structure[] array) {
  RL_09d38ca4875adba9fe0bf71f298f1c3d result = new RL_09d38ca4875adba9fe0bf71f298f1c3d();
result.InnerFromArray(array);
    return result;
}

public static RL_09d38ca4875adba9fe0bf71f298f1c3d ToList<T>(T[] array, Func <T, ST_f9be77c0ae9485d53ded05b1557548f9Structure> converter) {
  RL_09d38ca4875adba9fe0bf71f298f1c3d result = new RL_09d38ca4875adba9fe0bf71f298f1c3d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_09d38ca4875adba9fe0bf71f298f1c3d FromRestList<T>(RestList<T> restList, Func <T, ST_f9be77c0ae9485d53ded05b1557548f9Structure> converter) {
  RL_09d38ca4875adba9fe0bf71f298f1c3d result = new RL_09d38ca4875adba9fe0bf71f298f1c3d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_09d38ca4875adba9fe0bf71f298f1c3d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_f9be77c0ae9485d53ded05b1557548f9Structure> NewList() {
return new RL_09d38ca4875adba9fe0bf71f298f1c3d();
}


} // RL_09d38ca4875adba9fe0bf71f298f1c3d
}

