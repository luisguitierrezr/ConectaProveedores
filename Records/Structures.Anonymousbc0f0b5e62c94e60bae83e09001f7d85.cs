namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (XgsPvMliYE666D4JAB99hQ)
///  <code>RC_3e0fb635eefe948054fa75421546a901</code> that represent
/// s <code>RequisitionFile2Record</code> <p>Description: </p>
/// </summary>
// Name: RequisitionFile2Record
public partial struct RC_3e0fb635eefe948054fa75421546a901 : ITypedRecord<RC_3e0fb635eefe948054fa75421546a901> {
internal static readonly GlobalObjectKey IdRequisitionFile2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NbYPPv7ugJRU+nVCFUapAQ");

public EN_4cce425e15647f937e21de4e52849889EntityRecord ssENRequisitionFile2;


public static implicit operator EN_4cce425e15647f937e21de4e52849889EntityRecord( RC_3e0fb635eefe948054fa75421546a901 r) {
return r.ssENRequisitionFile2;
}

public static implicit operator RC_3e0fb635eefe948054fa75421546a901 (EN_4cce425e15647f937e21de4e52849889EntityRecord r) {
RC_3e0fb635eefe948054fa75421546a901 res = new RC_3e0fb635eefe948054fa75421546a901 ();
res.ssENRequisitionFile2 = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisitionFile2.ChangedAttributes = value;
}
get {
    return ssENRequisitionFile2.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_3e0fb635eefe948054fa75421546a901() {
OptimizedAttributes = null;
ssENRequisitionFile2 = new EN_4cce425e15647f937e21de4e52849889EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionFile2.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisitionFile2.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisitionFile2.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionFile2.Read( r, ref index);
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
public void ReadIM(RC_3e0fb635eefe948054fa75421546a901 r) {
this = r;
}


public static bool operator == (RC_3e0fb635eefe948054fa75421546a901 a, RC_3e0fb635eefe948054fa75421546a901 b) {
if (a.ssENRequisitionFile2 != b.ssENRequisitionFile2) return false;
return true;
}

public static bool operator != (RC_3e0fb635eefe948054fa75421546a901 a, RC_3e0fb635eefe948054fa75421546a901 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3e0fb635eefe948054fa75421546a901)) return false;
return (this == (RC_3e0fb635eefe948054fa75421546a901)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionFile2.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionFile2.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionFile2.InternalRecursiveSave();
}


public RC_3e0fb635eefe948054fa75421546a901 Duplicate() {
RC_3e0fb635eefe948054fa75421546a901 t;
t.ssENRequisitionFile2 = (EN_4cce425e15647f937e21de4e52849889EntityRecord)this.ssENRequisitionFile2.Duplicate();
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
if (head == "requisitionfile2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionFile2")) variable.Value = ssENRequisitionFile2; else variable.Optimized = true;
variable.SetFieldName("requisitionfile2");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionFile2.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionFile2.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisitionFile2) {
return ssENRequisitionFile2;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionFile2.Key.AsGuid) {
return ssENRequisitionFile2;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionFile2.FillFromOther((IRecord) other.AttributeGet(IdRequisitionFile2));
}
} // RC_3e0fb635eefe948054fa75421546a901
/// <summary>
/// RecordList type <code>RequisitionFile2RecordList</code> that represents a record list of
///  <code>RequisitionFile2</code>
/// </summary>
public partial class RL_2895ef65cfa24878b5b55c2c334b2f76 : GenericRecordList<RC_3e0fb635eefe948054fa75421546a901>, IEnumerable, IEnumerator {

protected override RC_3e0fb635eefe948054fa75421546a901 GetElementDefaultValue() {
return new RC_3e0fb635eefe948054fa75421546a901();
}

public T[] ToArray<T>(Func<RC_3e0fb635eefe948054fa75421546a901, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2895ef65cfa24878b5b55c2c334b2f76 recordList, Func<RC_3e0fb635eefe948054fa75421546a901, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2895ef65cfa24878b5b55c2c334b2f76(RC_3e0fb635eefe948054fa75421546a901[] array) {
  RL_2895ef65cfa24878b5b55c2c334b2f76 result = new RL_2895ef65cfa24878b5b55c2c334b2f76();
result.InnerFromArray(array);
    return result;
}

public static RL_2895ef65cfa24878b5b55c2c334b2f76 ToList<T>(T[] array, Func <T, RC_3e0fb635eefe948054fa75421546a901> converter) {
  RL_2895ef65cfa24878b5b55c2c334b2f76 result = new RL_2895ef65cfa24878b5b55c2c334b2f76();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2895ef65cfa24878b5b55c2c334b2f76 FromRestList<T>(RestList<T> restList, Func <T, RC_3e0fb635eefe948054fa75421546a901> converter) {
  RL_2895ef65cfa24878b5b55c2c334b2f76 result = new RL_2895ef65cfa24878b5b55c2c334b2f76();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2895ef65cfa24878b5b55c2c334b2f76() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3e0fb635eefe948054fa75421546a901> NewList() {
return new RL_2895ef65cfa24878b5b55c2c334b2f76();
}


} // RL_2895ef65cfa24878b5b55c2c334b2f76
}

