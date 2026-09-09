namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (mBbcqseDpU+eN07ZcrKQuA)
///  <code>RC_6db7d963170551ccb632da4db036570c</code> that represents <code>ItemEM_MORecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ItemEM_MORecord
public partial struct RC_6db7d963170551ccb632da4db036570c : ITypedRecord<RC_6db7d963170551ccb632da4db036570c> {
internal static readonly GlobalObjectKey IdItemEM_MO = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Y9m3bQUXzFG2MtpNsDZXDA");

public ST_8367d678111f49d602545a0a640615d6Structure ssSTItemEM_MO;


public static implicit operator ST_8367d678111f49d602545a0a640615d6Structure( RC_6db7d963170551ccb632da4db036570c r) {
return r.ssSTItemEM_MO;
}

public static implicit operator RC_6db7d963170551ccb632da4db036570c (ST_8367d678111f49d602545a0a640615d6Structure r) {
RC_6db7d963170551ccb632da4db036570c res = new RC_6db7d963170551ccb632da4db036570c ();
res.ssSTItemEM_MO = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_6db7d963170551ccb632da4db036570c() {
OptimizedAttributes = null;
ssSTItemEM_MO = new ST_8367d678111f49d602545a0a640615d6Structure();
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
    ssSTItemEM_MO.OptimizedAttributes = value[0];
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
ssSTItemEM_MO.Read( r, ref index);
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
public void ReadIM(RC_6db7d963170551ccb632da4db036570c r) {
this = r;
}


public static bool operator == (RC_6db7d963170551ccb632da4db036570c a, RC_6db7d963170551ccb632da4db036570c b) {
if (a.ssSTItemEM_MO != b.ssSTItemEM_MO) return false;
return true;
}

public static bool operator != (RC_6db7d963170551ccb632da4db036570c a, RC_6db7d963170551ccb632da4db036570c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6db7d963170551ccb632da4db036570c)) return false;
return (this == (RC_6db7d963170551ccb632da4db036570c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTItemEM_MO.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTItemEM_MO.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTItemEM_MO.InternalRecursiveSave();
}


public RC_6db7d963170551ccb632da4db036570c Duplicate() {
RC_6db7d963170551ccb632da4db036570c t;
t.ssSTItemEM_MO = (ST_8367d678111f49d602545a0a640615d6Structure)this.ssSTItemEM_MO.Duplicate();
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
if (head == "itemem_mo") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ItemEM_MO")) variable.Value = ssSTItemEM_MO; else variable.Optimized = true;
variable.SetFieldName("itemem_mo");
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
if (key == IdItemEM_MO) {
return ssSTItemEM_MO;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdItemEM_MO.Key.AsGuid) {
return ssSTItemEM_MO;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTItemEM_MO.FillFromOther((IRecord) other.AttributeGet(IdItemEM_MO));
}
} // RC_6db7d963170551ccb632da4db036570c
/// <summary>
/// RecordList type <code>ItemEM_MORecordList</code> that represents a record list of
///  <code>ItemEM_MO</code>
/// </summary>
public partial class RL_0dadf2471c5568d297f320b7fcb2d6a3 : GenericRecordList<RC_6db7d963170551ccb632da4db036570c>, IEnumerable, IEnumerator {

protected override RC_6db7d963170551ccb632da4db036570c GetElementDefaultValue() {
return new RC_6db7d963170551ccb632da4db036570c();
}

public T[] ToArray<T>(Func<RC_6db7d963170551ccb632da4db036570c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0dadf2471c5568d297f320b7fcb2d6a3 recordList, Func<RC_6db7d963170551ccb632da4db036570c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0dadf2471c5568d297f320b7fcb2d6a3(RC_6db7d963170551ccb632da4db036570c[] array) {
  RL_0dadf2471c5568d297f320b7fcb2d6a3 result = new RL_0dadf2471c5568d297f320b7fcb2d6a3();
result.InnerFromArray(array);
    return result;
}

public static RL_0dadf2471c5568d297f320b7fcb2d6a3 ToList<T>(T[] array, Func <T, RC_6db7d963170551ccb632da4db036570c> converter) {
  RL_0dadf2471c5568d297f320b7fcb2d6a3 result = new RL_0dadf2471c5568d297f320b7fcb2d6a3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0dadf2471c5568d297f320b7fcb2d6a3 FromRestList<T>(RestList<T> restList, Func <T, RC_6db7d963170551ccb632da4db036570c> converter) {
  RL_0dadf2471c5568d297f320b7fcb2d6a3 result = new RL_0dadf2471c5568d297f320b7fcb2d6a3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0dadf2471c5568d297f320b7fcb2d6a3() : base() {
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
protected override OSList<RC_6db7d963170551ccb632da4db036570c> NewList() {
return new RL_0dadf2471c5568d297f320b7fcb2d6a3();
}


} // RL_0dadf2471c5568d297f320b7fcb2d6a3
}

