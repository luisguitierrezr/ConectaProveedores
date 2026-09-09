namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (+4Hzkv+BSE6_HpNuA6eYwA)
///  <code>RC_bc90ae5f0dadb418c4abf32f2cb9fe8c</code> that represents <code>ItemSMRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ItemSMRecord
public partial struct RC_bc90ae5f0dadb418c4abf32f2cb9fe8c : ITypedRecord<RC_bc90ae5f0dadb418c4abf32f2cb9fe8c> {
internal static readonly GlobalObjectKey IdItemSM = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*X66QvK0NGLTEq_MvLLn+jA");

public ST_ab77394b00ae0f5875687584d175cf59Structure ssSTItemSM;


public static implicit operator ST_ab77394b00ae0f5875687584d175cf59Structure( RC_bc90ae5f0dadb418c4abf32f2cb9fe8c r) {
return r.ssSTItemSM;
}

public static implicit operator RC_bc90ae5f0dadb418c4abf32f2cb9fe8c (ST_ab77394b00ae0f5875687584d175cf59Structure r) {
RC_bc90ae5f0dadb418c4abf32f2cb9fe8c res = new RC_bc90ae5f0dadb418c4abf32f2cb9fe8c ();
res.ssSTItemSM = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_bc90ae5f0dadb418c4abf32f2cb9fe8c() {
OptimizedAttributes = null;
ssSTItemSM = new ST_ab77394b00ae0f5875687584d175cf59Structure();
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
    ssSTItemSM.OptimizedAttributes = value[0];
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
ssSTItemSM.Read( r, ref index);
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
public void ReadIM(RC_bc90ae5f0dadb418c4abf32f2cb9fe8c r) {
this = r;
}


public static bool operator == (RC_bc90ae5f0dadb418c4abf32f2cb9fe8c a, RC_bc90ae5f0dadb418c4abf32f2cb9fe8c b) {
if (a.ssSTItemSM != b.ssSTItemSM) return false;
return true;
}

public static bool operator != (RC_bc90ae5f0dadb418c4abf32f2cb9fe8c a, RC_bc90ae5f0dadb418c4abf32f2cb9fe8c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_bc90ae5f0dadb418c4abf32f2cb9fe8c)) return false;
return (this == (RC_bc90ae5f0dadb418c4abf32f2cb9fe8c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTItemSM.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTItemSM.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTItemSM.InternalRecursiveSave();
}


public RC_bc90ae5f0dadb418c4abf32f2cb9fe8c Duplicate() {
RC_bc90ae5f0dadb418c4abf32f2cb9fe8c t;
t.ssSTItemSM = (ST_ab77394b00ae0f5875687584d175cf59Structure)this.ssSTItemSM.Duplicate();
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
if (head == "itemsm") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemSM")) variable.Value = ssSTItemSM; else variable.Optimized = true;
variable.SetFieldName("itemsm");
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
if (key == IdItemSM) {
return ssSTItemSM;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdItemSM.Key.AsGuid) {
return ssSTItemSM;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTItemSM.FillFromOther((IRecord) other.AttributeGet(IdItemSM));
}
} // RC_bc90ae5f0dadb418c4abf32f2cb9fe8c
/// <summary>
/// RecordList type <code>ItemSMRecordList</code> that represents a record list of <code>ItemSM</code>
/// </summary>
public partial class RL_501b37c07df9af80fe098f8881369279 : GenericRecordList<RC_bc90ae5f0dadb418c4abf32f2cb9fe8c>, IEnumerable, IEnumerator {

protected override RC_bc90ae5f0dadb418c4abf32f2cb9fe8c GetElementDefaultValue() {
return new RC_bc90ae5f0dadb418c4abf32f2cb9fe8c();
}

public T[] ToArray<T>(Func<RC_bc90ae5f0dadb418c4abf32f2cb9fe8c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_501b37c07df9af80fe098f8881369279 recordList, Func<RC_bc90ae5f0dadb418c4abf32f2cb9fe8c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_501b37c07df9af80fe098f8881369279(RC_bc90ae5f0dadb418c4abf32f2cb9fe8c[] array) {
  RL_501b37c07df9af80fe098f8881369279 result = new RL_501b37c07df9af80fe098f8881369279();
result.InnerFromArray(array);
    return result;
}

public static RL_501b37c07df9af80fe098f8881369279 ToList<T>(T[] array, Func <T, RC_bc90ae5f0dadb418c4abf32f2cb9fe8c> converter) {
  RL_501b37c07df9af80fe098f8881369279 result = new RL_501b37c07df9af80fe098f8881369279();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_501b37c07df9af80fe098f8881369279 FromRestList<T>(RestList<T> restList, Func <T, RC_bc90ae5f0dadb418c4abf32f2cb9fe8c> converter) {
  RL_501b37c07df9af80fe098f8881369279 result = new RL_501b37c07df9af80fe098f8881369279();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_501b37c07df9af80fe098f8881369279() : base() {
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
protected override OSList<RC_bc90ae5f0dadb418c4abf32f2cb9fe8c> NewList() {
return new RL_501b37c07df9af80fe098f8881369279();
}


} // RL_501b37c07df9af80fe098f8881369279
}

