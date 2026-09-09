namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Ewb+VHWiaEe8VXNpA6p3FA)
///  <code>RC_6d2bef4b7e32de4c7c78886eeff75224</code> that represent
/// s <code>RequisitionApprovalRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionApprovalRecord
public partial struct RC_6d2bef4b7e32de4c7c78886eeff75224 : ITypedRecord<RC_6d2bef4b7e32de4c7c78886eeff75224> {
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;


public static implicit operator EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord( RC_6d2bef4b7e32de4c7c78886eeff75224 r) {
return r.ssENRequisitionApproval;
}

public static implicit operator RC_6d2bef4b7e32de4c7c78886eeff75224 (EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord r) {
RC_6d2bef4b7e32de4c7c78886eeff75224 res = new RC_6d2bef4b7e32de4c7c78886eeff75224 ();
res.ssENRequisitionApproval = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisitionApproval.ChangedAttributes = value;
}
get {
    return ssENRequisitionApproval.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_6d2bef4b7e32de4c7c78886eeff75224() {
OptimizedAttributes = null;
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisitionApproval.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisitionApproval.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionApproval.Read( r, ref index);
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
public void ReadIM(RC_6d2bef4b7e32de4c7c78886eeff75224 r) {
this = r;
}


public static bool operator == (RC_6d2bef4b7e32de4c7c78886eeff75224 a, RC_6d2bef4b7e32de4c7c78886eeff75224 b) {
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
return true;
}

public static bool operator != (RC_6d2bef4b7e32de4c7c78886eeff75224 a, RC_6d2bef4b7e32de4c7c78886eeff75224 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6d2bef4b7e32de4c7c78886eeff75224)) return false;
return (this == (RC_6d2bef4b7e32de4c7c78886eeff75224)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionApproval.InternalRecursiveSave();
}


public RC_6d2bef4b7e32de4c7c78886eeff75224 Duplicate() {
RC_6d2bef4b7e32de4c7c78886eeff75224 t;
t.ssENRequisitionApproval = (EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord)this.ssENRequisitionApproval.Duplicate();
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
if (head == "requisitionapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApproval")) variable.Value = ssENRequisitionApproval; else variable.Optimized = true;
variable.SetFieldName("requisitionapproval");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionApproval.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionApproval.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisitionApproval) {
return ssENRequisitionApproval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionApproval.Key.AsGuid) {
return ssENRequisitionApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
}
} // RC_6d2bef4b7e32de4c7c78886eeff75224
/// <summary>
/// RecordList type <code>RequisitionApprovalRecordList</code> that represents a record list of
///  <code>RequisitionApproval</code>
/// </summary>
public partial class RL_7f2260a280cd6c85f68a2e5dbb44ffad : GenericRecordList<RC_6d2bef4b7e32de4c7c78886eeff75224>, IEnumerable, IEnumerator {

protected override RC_6d2bef4b7e32de4c7c78886eeff75224 GetElementDefaultValue() {
return new RC_6d2bef4b7e32de4c7c78886eeff75224();
}

public T[] ToArray<T>(Func<RC_6d2bef4b7e32de4c7c78886eeff75224, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_7f2260a280cd6c85f68a2e5dbb44ffad recordList, Func<RC_6d2bef4b7e32de4c7c78886eeff75224, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_7f2260a280cd6c85f68a2e5dbb44ffad(RC_6d2bef4b7e32de4c7c78886eeff75224[] array) {
  RL_7f2260a280cd6c85f68a2e5dbb44ffad result = new RL_7f2260a280cd6c85f68a2e5dbb44ffad();
result.InnerFromArray(array);
    return result;
}

public static RL_7f2260a280cd6c85f68a2e5dbb44ffad ToList<T>(T[] array, Func <T, RC_6d2bef4b7e32de4c7c78886eeff75224> converter) {
  RL_7f2260a280cd6c85f68a2e5dbb44ffad result = new RL_7f2260a280cd6c85f68a2e5dbb44ffad();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_7f2260a280cd6c85f68a2e5dbb44ffad FromRestList<T>(RestList<T> restList, Func <T, RC_6d2bef4b7e32de4c7c78886eeff75224> converter) {
  RL_7f2260a280cd6c85f68a2e5dbb44ffad result = new RL_7f2260a280cd6c85f68a2e5dbb44ffad();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_7f2260a280cd6c85f68a2e5dbb44ffad() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6d2bef4b7e32de4c7c78886eeff75224> NewList() {
return new RL_7f2260a280cd6c85f68a2e5dbb44ffad();
}


} // RL_7f2260a280cd6c85f68a2e5dbb44ffad
}

