namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] Users3 (pJzbvueXq0yD06VbgnJsZQ)
///  <code>ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure</code> that represents <code>Users3</code
/// > <p>Description: </p>
/// </summary>
// Name: Users3
public partial struct ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure : ITypedRecord<ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure> {
internal static readonly GlobalObjectKey Idodata_context = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*WU2dMMKoAU+Pg_bEXMV67w");
internal static readonly GlobalObjectKey Idodata_nextLink = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*Y_Z4UJ9Fu0u_m6AkpFhNdA");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*Ct1toCB060eDWtutG4xNlw");

public string ssodata_context;

public string ssodata_nextLink;

public RL_c68f8e92ccdada3f2f3589e091be34b8 ssValue;


public BitArray OptimizedAttributes;

public ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure() {
OptimizedAttributes = null;
ssodata_context = "";
ssodata_nextLink = "";
ssValue = new RL_c68f8e92ccdada3f2f3589e091be34b8();
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
ssodata_context = r.ReadText(index++, "Users3.odata_context", "");
ssodata_nextLink = r.ReadText(index++, "Users3.odata_nextLink", "");
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
public void ReadIM(ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure r) {
this = r;
}


public static bool operator == (ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure a, ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure b) {
if (a.ssodata_context != b.ssodata_context) return false;
if (a.ssodata_nextLink != b.ssodata_nextLink) return false;
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure a, ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure)) return false;
return (this == (ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssodata_context.GetHashCode()
 ^ ssodata_nextLink.GetHashCode()
 ^ ssValue.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssValue.RecursiveReset();
}

public void InternalRecursiveSave() {
ssValue.InternalRecursiveSave();
}


public ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure Duplicate() {
ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure t;
t.ssodata_context = this.ssodata_context;
t.ssodata_nextLink = this.ssodata_nextLink;
t.ssValue = (RL_c68f8e92ccdada3f2f3589e091be34b8)this.ssValue.Duplicate();
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
if (head == "odata_context") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".odata_context")) variable.Value = ssodata_context; else variable.Optimized = true;
} else if (head == "odata_nextlink") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".odata_nextLink")) variable.Value = ssodata_nextLink; else variable.Optimized = true;
} else if (head == "value") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Value")) variable.Value = ssValue; else variable.Optimized = true;
variable.SetFieldName("value");
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
if (key == Idodata_context) {
return ssodata_context;
}
if (key == Idodata_nextLink) {
return ssodata_nextLink;
}
if (key == IdValue) {
return ssValue;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == Idodata_context.Key.AsGuid) {
return ssodata_context;
}
if (attributeKey == Idodata_nextLink.Key.AsGuid) {
return ssodata_nextLink;
}
if (attributeKey == IdValue.Key.AsGuid) {
return ssValue;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssodata_context = (string) other.AttributeGet(Idodata_context);
ssodata_nextLink = (string) other.AttributeGet(Idodata_nextLink);
ssValue = new RL_c68f8e92ccdada3f2f3589e091be34b8();
ssValue.FillFromOther((IOSList) other.AttributeGet(IdValue));
}
} // ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure
/// <summary>
/// RecordList type <code>Users3List</code> that represents a record list of <code>Users3</code>
/// </summary>
public partial class RL_f7889af47c635b9a4538ff77a3431a5b : GenericRecordList<ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure>, IEnumerable, IEnumerator {

protected override ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure GetElementDefaultValue() {
return new ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure();
}

public T[] ToArray<T>(Func<ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f7889af47c635b9a4538ff77a3431a5b recordList, Func<ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f7889af47c635b9a4538ff77a3431a5b(ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure[] array) {
  RL_f7889af47c635b9a4538ff77a3431a5b result = new RL_f7889af47c635b9a4538ff77a3431a5b();
result.InnerFromArray(array);
    return result;
}

public static RL_f7889af47c635b9a4538ff77a3431a5b ToList<T>(T[] array, Func <T, ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure> converter) {
  RL_f7889af47c635b9a4538ff77a3431a5b result = new RL_f7889af47c635b9a4538ff77a3431a5b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f7889af47c635b9a4538ff77a3431a5b FromRestList<T>(RestList<T> restList, Func <T, ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure> converter) {
  RL_f7889af47c635b9a4538ff77a3431a5b result = new RL_f7889af47c635b9a4538ff77a3431a5b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f7889af47c635b9a4538ff77a3431a5b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_0b84413d87b4ebcdcd31f2ae9d2fd617Structure> NewList() {
return new RL_f7889af47c635b9a4538ff77a3431a5b();
}


} // RL_f7889af47c635b9a4538ff77a3431a5b
}

