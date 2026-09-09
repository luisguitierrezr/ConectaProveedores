namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (R7hvrFEpTkqQh_6h1wukeA)
///  <code>RC_f8549493bcd7ba8b9e84758a4cb06ac7</code> that represents <code>ValueItem2Record</code
/// > <p>Description: </p>
/// </summary>
// Name: ValueItem2Record
public partial struct RC_f8549493bcd7ba8b9e84758a4cb06ac7 : ITypedRecord<RC_f8549493bcd7ba8b9e84758a4cb06ac7> {
internal static readonly GlobalObjectKey IdValueItem2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k5RU+Ne8i7qehHWKTLBqxw");

public ST_7d9cb56357295234b770124829cebf1bStructure ssSTValueItem2;


public static implicit operator ST_7d9cb56357295234b770124829cebf1bStructure( RC_f8549493bcd7ba8b9e84758a4cb06ac7 r) {
return r.ssSTValueItem2;
}

public static implicit operator RC_f8549493bcd7ba8b9e84758a4cb06ac7 (ST_7d9cb56357295234b770124829cebf1bStructure r) {
RC_f8549493bcd7ba8b9e84758a4cb06ac7 res = new RC_f8549493bcd7ba8b9e84758a4cb06ac7 ();
res.ssSTValueItem2 = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_f8549493bcd7ba8b9e84758a4cb06ac7() {
OptimizedAttributes = null;
ssSTValueItem2 = new ST_7d9cb56357295234b770124829cebf1bStructure();
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
    ssSTValueItem2.OptimizedAttributes = value[0];
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
ssSTValueItem2.Read( r, ref index);
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
public void ReadIM(RC_f8549493bcd7ba8b9e84758a4cb06ac7 r) {
this = r;
}


public static bool operator == (RC_f8549493bcd7ba8b9e84758a4cb06ac7 a, RC_f8549493bcd7ba8b9e84758a4cb06ac7 b) {
if (a.ssSTValueItem2 != b.ssSTValueItem2) return false;
return true;
}

public static bool operator != (RC_f8549493bcd7ba8b9e84758a4cb06ac7 a, RC_f8549493bcd7ba8b9e84758a4cb06ac7 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f8549493bcd7ba8b9e84758a4cb06ac7)) return false;
return (this == (RC_f8549493bcd7ba8b9e84758a4cb06ac7)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTValueItem2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTValueItem2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTValueItem2.InternalRecursiveSave();
}


public RC_f8549493bcd7ba8b9e84758a4cb06ac7 Duplicate() {
RC_f8549493bcd7ba8b9e84758a4cb06ac7 t;
t.ssSTValueItem2 = (ST_7d9cb56357295234b770124829cebf1bStructure)this.ssSTValueItem2.Duplicate();
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
if (head == "valueitem2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ValueItem2")) variable.Value = ssSTValueItem2; else variable.Optimized = true;
variable.SetFieldName("valueitem2");
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
if (key == IdValueItem2) {
return ssSTValueItem2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdValueItem2.Key.AsGuid) {
return ssSTValueItem2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTValueItem2.FillFromOther((IRecord) other.AttributeGet(IdValueItem2));
}
} // RC_f8549493bcd7ba8b9e84758a4cb06ac7
/// <summary>
/// RecordList type <code>ValueItem2RecordList</code> that represents a record list of
///  <code>ValueItem2</code>
/// </summary>
public partial class RL_7264ebaa1683d2ff384650b79d0a6b95 : GenericRecordList<RC_f8549493bcd7ba8b9e84758a4cb06ac7>, IEnumerable, IEnumerator {

protected override RC_f8549493bcd7ba8b9e84758a4cb06ac7 GetElementDefaultValue() {
return new RC_f8549493bcd7ba8b9e84758a4cb06ac7();
}

public T[] ToArray<T>(Func<RC_f8549493bcd7ba8b9e84758a4cb06ac7, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7264ebaa1683d2ff384650b79d0a6b95 recordList, Func<RC_f8549493bcd7ba8b9e84758a4cb06ac7, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7264ebaa1683d2ff384650b79d0a6b95(RC_f8549493bcd7ba8b9e84758a4cb06ac7[] array) {
  RL_7264ebaa1683d2ff384650b79d0a6b95 result = new RL_7264ebaa1683d2ff384650b79d0a6b95();
result.InnerFromArray(array);
    return result;
}

public static RL_7264ebaa1683d2ff384650b79d0a6b95 ToList<T>(T[] array, Func <T, RC_f8549493bcd7ba8b9e84758a4cb06ac7> converter) {
  RL_7264ebaa1683d2ff384650b79d0a6b95 result = new RL_7264ebaa1683d2ff384650b79d0a6b95();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7264ebaa1683d2ff384650b79d0a6b95 FromRestList<T>(RestList<T> restList, Func <T, RC_f8549493bcd7ba8b9e84758a4cb06ac7> converter) {
  RL_7264ebaa1683d2ff384650b79d0a6b95 result = new RL_7264ebaa1683d2ff384650b79d0a6b95();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7264ebaa1683d2ff384650b79d0a6b95() : base() {
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
protected override OSList<RC_f8549493bcd7ba8b9e84758a4cb06ac7> NewList() {
return new RL_7264ebaa1683d2ff384650b79d0a6b95();
}


} // RL_7264ebaa1683d2ff384650b79d0a6b95
}

