namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] PI_ITEM_EM_MO (qrfWRrkKQEKCSQkJf7tccg)
///  <code>ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure</code> that represent
/// s <code>PI_ITEM_EM_MO</code> <p>Description: PI_ITEM_EM_MO</p>
/// </summary>
// Name: PI_ITEM_EM_MO
public partial struct ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure : ITypedRecord<ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure> {
internal static readonly GlobalObjectKey IdItem = GlobalObjectKey.Parse("W2g2vJ1htkyBZ_pD4Lqsqw*uELcYdVH2EiX0BAdVtD3pg");

public RL_4d0d602433bf72956981903b88f22e91 ssItem;


public BitArray OptimizedAttributes;

public ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure() {
OptimizedAttributes = null;
ssItem = new RL_4d0d602433bf72956981903b88f22e91();
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
public void ReadIM(ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure r) {
this = r;
}


public static bool operator == (ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure a, ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure b) {
if (a.ssItem != b.ssItem) return false;
return true;
}

public static bool operator != (ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure a, ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure)) return false;
return (this == (ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssItem.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssItem.RecursiveReset();
}

public void InternalRecursiveSave() {
ssItem.InternalRecursiveSave();
}


public ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure Duplicate() {
ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure t;
t.ssItem = (RL_4d0d602433bf72956981903b88f22e91)this.ssItem.Duplicate();
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
if (head == "item") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Item")) variable.Value = ssItem; else variable.Optimized = true;
variable.SetFieldName("item");
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
if (key == IdItem) {
return ssItem;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdItem.Key.AsGuid) {
return ssItem;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssItem = new RL_4d0d602433bf72956981903b88f22e91();
ssItem.FillFromOther((IOSList) other.AttributeGet(IdItem));
}
} // ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure
/// <summary>
/// RecordList type <code>PI_ITEM_EM_MOList</code> that represents a record list of
///  <code>PI_ITEM_EM_MO</code>
/// </summary>
public partial class RL_7b92a36bd032c7bc8334de45476d8db2 : GenericRecordList<ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure>, IEnumerable, IEnumerator {

protected override ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure GetElementDefaultValue() {
return new ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure();
}

public T[] ToArray<T>(Func<ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7b92a36bd032c7bc8334de45476d8db2 recordList, Func<ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7b92a36bd032c7bc8334de45476d8db2(ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure[] array) {
  RL_7b92a36bd032c7bc8334de45476d8db2 result = new RL_7b92a36bd032c7bc8334de45476d8db2();
result.InnerFromArray(array);
    return result;
}

public static RL_7b92a36bd032c7bc8334de45476d8db2 ToList<T>(T[] array, Func <T, ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure> converter) {
  RL_7b92a36bd032c7bc8334de45476d8db2 result = new RL_7b92a36bd032c7bc8334de45476d8db2();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7b92a36bd032c7bc8334de45476d8db2 FromRestList<T>(RestList<T> restList, Func <T, ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure> converter) {
  RL_7b92a36bd032c7bc8334de45476d8db2 result = new RL_7b92a36bd032c7bc8334de45476d8db2();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7b92a36bd032c7bc8334de45476d8db2() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_b66fb52d7e61909cfa3b37d2fa32ed69Structure> NewList() {
return new RL_7b92a36bd032c7bc8334de45476d8db2();
}


} // RL_7b92a36bd032c7bc8334de45476d8db2
}

