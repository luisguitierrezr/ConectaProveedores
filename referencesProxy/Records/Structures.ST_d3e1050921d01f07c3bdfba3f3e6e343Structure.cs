namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] GetGroupsResponse (esdvnzLULEiXoLmCOG6VIg)
///  <code>ST_d3e1050921d01f07c3bdfba3f3e6e343Structure</code> that represent
/// s <code>GetGroupsResponse</code> <p>Description: </p>
/// </summary>
// Name: GetGroupsResponse
public partial struct ST_d3e1050921d01f07c3bdfba3f3e6e343Structure : ITypedRecord<ST_d3e1050921d01f07c3bdfba3f3e6e343Structure> {
internal static readonly GlobalObjectKey Idodata_context = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*xOYQx5XWVkKQzCO7nQR97Q");
internal static readonly GlobalObjectKey Idodata_nextLink = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*42aGh4mypUKKZ3YHZVfFtw");
internal static readonly GlobalObjectKey IdValue = GlobalObjectKey.Parse("fOFA5peUjUuSfOokWq1NWQ*RQYZnf9GdkG4sxE+12fveg");

public string ssodata_context;

public string ssodata_nextLink;

public RL_ae05fe34dabbae8c8aefa197aab938f8 ssValue;


public BitArray OptimizedAttributes;

public ST_d3e1050921d01f07c3bdfba3f3e6e343Structure() {
OptimizedAttributes = null;
ssodata_context = "";
ssodata_nextLink = "";
ssValue = new RL_ae05fe34dabbae8c8aefa197aab938f8();
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
ssodata_context = r.ReadText(index++, "GetGroupsResponse.odata_context", "");
ssodata_nextLink = r.ReadText(index++, "GetGroupsResponse.odata_nextLink", "");
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
public void ReadIM(ST_d3e1050921d01f07c3bdfba3f3e6e343Structure r) {
this = r;
}


public static bool operator == (ST_d3e1050921d01f07c3bdfba3f3e6e343Structure a, ST_d3e1050921d01f07c3bdfba3f3e6e343Structure b) {
if (a.ssodata_context != b.ssodata_context) return false;
if (a.ssodata_nextLink != b.ssodata_nextLink) return false;
if (a.ssValue != b.ssValue) return false;
return true;
}

public static bool operator != (ST_d3e1050921d01f07c3bdfba3f3e6e343Structure a, ST_d3e1050921d01f07c3bdfba3f3e6e343Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_d3e1050921d01f07c3bdfba3f3e6e343Structure)) return false;
return (this == (ST_d3e1050921d01f07c3bdfba3f3e6e343Structure)o);
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


public ST_d3e1050921d01f07c3bdfba3f3e6e343Structure Duplicate() {
ST_d3e1050921d01f07c3bdfba3f3e6e343Structure t;
t.ssodata_context = this.ssodata_context;
t.ssodata_nextLink = this.ssodata_nextLink;
t.ssValue = (RL_ae05fe34dabbae8c8aefa197aab938f8)this.ssValue.Duplicate();
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
ssValue = new RL_ae05fe34dabbae8c8aefa197aab938f8();
ssValue.FillFromOther((IOSList) other.AttributeGet(IdValue));
}
} // ST_d3e1050921d01f07c3bdfba3f3e6e343Structure
/// <summary>
/// RecordList type <code>GetGroupsResponseList</code> that represents a record list of
///  <code>GetGroupsResponse</code>
/// </summary>
public partial class RL_4a64eeef20a906d6b1075155662fc7e6 : GenericRecordList<ST_d3e1050921d01f07c3bdfba3f3e6e343Structure>, IEnumerable, IEnumerator {

protected override ST_d3e1050921d01f07c3bdfba3f3e6e343Structure GetElementDefaultValue() {
return new ST_d3e1050921d01f07c3bdfba3f3e6e343Structure();
}

public T[] ToArray<T>(Func<ST_d3e1050921d01f07c3bdfba3f3e6e343Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4a64eeef20a906d6b1075155662fc7e6 recordList, Func<ST_d3e1050921d01f07c3bdfba3f3e6e343Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4a64eeef20a906d6b1075155662fc7e6(ST_d3e1050921d01f07c3bdfba3f3e6e343Structure[] array) {
  RL_4a64eeef20a906d6b1075155662fc7e6 result = new RL_4a64eeef20a906d6b1075155662fc7e6();
result.InnerFromArray(array);
    return result;
}

public static RL_4a64eeef20a906d6b1075155662fc7e6 ToList<T>(T[] array, Func <T, ST_d3e1050921d01f07c3bdfba3f3e6e343Structure> converter) {
  RL_4a64eeef20a906d6b1075155662fc7e6 result = new RL_4a64eeef20a906d6b1075155662fc7e6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4a64eeef20a906d6b1075155662fc7e6 FromRestList<T>(RestList<T> restList, Func <T, ST_d3e1050921d01f07c3bdfba3f3e6e343Structure> converter) {
  RL_4a64eeef20a906d6b1075155662fc7e6 result = new RL_4a64eeef20a906d6b1075155662fc7e6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4a64eeef20a906d6b1075155662fc7e6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_d3e1050921d01f07c3bdfba3f3e6e343Structure> NewList() {
return new RL_4a64eeef20a906d6b1075155662fc7e6();
}


} // RL_4a64eeef20a906d6b1075155662fc7e6
}

