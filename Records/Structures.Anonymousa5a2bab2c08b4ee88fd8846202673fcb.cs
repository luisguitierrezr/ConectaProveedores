namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (srqipYvA6E6P2IRiAmc_yw)
///  <code>RC_eadaf2f9446fb019e39088d303bee2ef</code> that represent
/// s <code>OrderMainItemStatusRecord</code> <p>Description: </p>
/// </summary>
// Name: OrderMainItemStatusRecord
public partial struct RC_eadaf2f9446fb019e39088d303bee2ef : ITypedRecord<RC_eadaf2f9446fb019e39088d303bee2ef> {
internal static readonly GlobalObjectKey IdOrderMainItemStatus = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+fLa6m9EGbDjkIjTA77i7w");

public EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord ssENOrderMainItemStatus;


public static implicit operator EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord( RC_eadaf2f9446fb019e39088d303bee2ef r) {
return r.ssENOrderMainItemStatus;
}

public static implicit operator RC_eadaf2f9446fb019e39088d303bee2ef (EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord r) {
RC_eadaf2f9446fb019e39088d303bee2ef res = new RC_eadaf2f9446fb019e39088d303bee2ef ();
res.ssENOrderMainItemStatus = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrderMainItemStatus.ChangedAttributes = value;
}
get {
    return ssENOrderMainItemStatus.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_eadaf2f9446fb019e39088d303bee2ef() {
OptimizedAttributes = null;
ssENOrderMainItemStatus = new EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrderMainItemStatus.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrderMainItemStatus.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrderMainItemStatus.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrderMainItemStatus.Read( r, ref index);
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
public void ReadIM(RC_eadaf2f9446fb019e39088d303bee2ef r) {
this = r;
}


public static bool operator == (RC_eadaf2f9446fb019e39088d303bee2ef a, RC_eadaf2f9446fb019e39088d303bee2ef b) {
if (a.ssENOrderMainItemStatus != b.ssENOrderMainItemStatus) return false;
return true;
}

public static bool operator != (RC_eadaf2f9446fb019e39088d303bee2ef a, RC_eadaf2f9446fb019e39088d303bee2ef b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_eadaf2f9446fb019e39088d303bee2ef)) return false;
return (this == (RC_eadaf2f9446fb019e39088d303bee2ef)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrderMainItemStatus.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrderMainItemStatus.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrderMainItemStatus.InternalRecursiveSave();
}


public RC_eadaf2f9446fb019e39088d303bee2ef Duplicate() {
RC_eadaf2f9446fb019e39088d303bee2ef t;
t.ssENOrderMainItemStatus = (EN_1818af806b24ac9b9d43f3fa206f0de5EntityRecord)this.ssENOrderMainItemStatus.Duplicate();
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
if (head == "ordermainitemstatus") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMainItemStatus")) variable.Value = ssENOrderMainItemStatus; else variable.Optimized = true;
variable.SetFieldName("ordermainitemstatus");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrderMainItemStatus.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrderMainItemStatus.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrderMainItemStatus) {
return ssENOrderMainItemStatus;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrderMainItemStatus.Key.AsGuid) {
return ssENOrderMainItemStatus;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrderMainItemStatus.FillFromOther((IRecord) other.AttributeGet(IdOrderMainItemStatus));
}
} // RC_eadaf2f9446fb019e39088d303bee2ef
/// <summary>
/// RecordList type <code>OrderMainItemStatusRecordList</code> that represents a record list of
///  <code>OrderMainItemStatus</code>
/// </summary>
public partial class RL_6bad975cbaebab390c5fb737b3d25ba1 : GenericRecordList<RC_eadaf2f9446fb019e39088d303bee2ef>, IEnumerable, IEnumerator {

protected override RC_eadaf2f9446fb019e39088d303bee2ef GetElementDefaultValue() {
return new RC_eadaf2f9446fb019e39088d303bee2ef();
}

public T[] ToArray<T>(Func<RC_eadaf2f9446fb019e39088d303bee2ef, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6bad975cbaebab390c5fb737b3d25ba1 recordList, Func<RC_eadaf2f9446fb019e39088d303bee2ef, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6bad975cbaebab390c5fb737b3d25ba1(RC_eadaf2f9446fb019e39088d303bee2ef[] array) {
  RL_6bad975cbaebab390c5fb737b3d25ba1 result = new RL_6bad975cbaebab390c5fb737b3d25ba1();
result.InnerFromArray(array);
    return result;
}

public static RL_6bad975cbaebab390c5fb737b3d25ba1 ToList<T>(T[] array, Func <T, RC_eadaf2f9446fb019e39088d303bee2ef> converter) {
  RL_6bad975cbaebab390c5fb737b3d25ba1 result = new RL_6bad975cbaebab390c5fb737b3d25ba1();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6bad975cbaebab390c5fb737b3d25ba1 FromRestList<T>(RestList<T> restList, Func <T, RC_eadaf2f9446fb019e39088d303bee2ef> converter) {
  RL_6bad975cbaebab390c5fb737b3d25ba1 result = new RL_6bad975cbaebab390c5fb737b3d25ba1();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6bad975cbaebab390c5fb737b3d25ba1() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_eadaf2f9446fb019e39088d303bee2ef> NewList() {
return new RL_6bad975cbaebab390c5fb737b3d25ba1();
}


} // RL_6bad975cbaebab390c5fb737b3d25ba1
}

