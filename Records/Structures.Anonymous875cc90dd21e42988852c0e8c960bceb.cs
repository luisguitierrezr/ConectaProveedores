namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Dclchx7SmEKIUsDoyWC86w)
///  <code>RC_5404698ef74632f0bc59763509d95177</code> that represent
/// s <code>RequisitionApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionApprovalLevelRecord
public partial struct RC_5404698ef74632f0bc59763509d95177 : ITypedRecord<RC_5404698ef74632f0bc59763509d95177> {
internal static readonly GlobalObjectKey IdRequisitionApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jmkEVEb38DK8WXY1CdlRdw");

public EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel;


public static implicit operator EN_27b1469f497d364a764a1359956ef9adEntityRecord( RC_5404698ef74632f0bc59763509d95177 r) {
return r.ssENRequisitionApprovalLevel;
}

public static implicit operator RC_5404698ef74632f0bc59763509d95177 (EN_27b1469f497d364a764a1359956ef9adEntityRecord r) {
RC_5404698ef74632f0bc59763509d95177 res = new RC_5404698ef74632f0bc59763509d95177 ();
res.ssENRequisitionApprovalLevel = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisitionApprovalLevel.ChangedAttributes = value;
}
get {
    return ssENRequisitionApprovalLevel.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_5404698ef74632f0bc59763509d95177() {
OptimizedAttributes = null;
ssENRequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(26,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisitionApprovalLevel.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisitionApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_5404698ef74632f0bc59763509d95177 r) {
this = r;
}


public static bool operator == (RC_5404698ef74632f0bc59763509d95177 a, RC_5404698ef74632f0bc59763509d95177 b) {
if (a.ssENRequisitionApprovalLevel != b.ssENRequisitionApprovalLevel) return false;
return true;
}

public static bool operator != (RC_5404698ef74632f0bc59763509d95177 a, RC_5404698ef74632f0bc59763509d95177 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5404698ef74632f0bc59763509d95177)) return false;
return (this == (RC_5404698ef74632f0bc59763509d95177)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionApprovalLevel.InternalRecursiveSave();
}


public RC_5404698ef74632f0bc59763509d95177 Duplicate() {
RC_5404698ef74632f0bc59763509d95177 t;
t.ssENRequisitionApprovalLevel = (EN_27b1469f497d364a764a1359956ef9adEntityRecord)this.ssENRequisitionApprovalLevel.Duplicate();
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
if (head == "requisitionapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApprovalLevel")) variable.Value = ssENRequisitionApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("requisitionapprovallevel");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionApprovalLevel.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionApprovalLevel.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisitionApprovalLevel) {
return ssENRequisitionApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionApprovalLevel.Key.AsGuid) {
return ssENRequisitionApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApprovalLevel));
}
} // RC_5404698ef74632f0bc59763509d95177
/// <summary>
/// RecordList type <code>RequisitionApprovalLevelRecordList</code> that represents a record list of
///  <code>RequisitionApprovalLevel</code>
/// </summary>
public partial class RL_d8bc800f4e3c344ab91bf54150e31a34 : GenericRecordList<RC_5404698ef74632f0bc59763509d95177>, IEnumerable, IEnumerator {

protected override RC_5404698ef74632f0bc59763509d95177 GetElementDefaultValue() {
return new RC_5404698ef74632f0bc59763509d95177();
}

public T[] ToArray<T>(Func<RC_5404698ef74632f0bc59763509d95177, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d8bc800f4e3c344ab91bf54150e31a34 recordList, Func<RC_5404698ef74632f0bc59763509d95177, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d8bc800f4e3c344ab91bf54150e31a34(RC_5404698ef74632f0bc59763509d95177[] array) {
  RL_d8bc800f4e3c344ab91bf54150e31a34 result = new RL_d8bc800f4e3c344ab91bf54150e31a34();
result.InnerFromArray(array);
    return result;
}

public static RL_d8bc800f4e3c344ab91bf54150e31a34 ToList<T>(T[] array, Func <T, RC_5404698ef74632f0bc59763509d95177> converter) {
  RL_d8bc800f4e3c344ab91bf54150e31a34 result = new RL_d8bc800f4e3c344ab91bf54150e31a34();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d8bc800f4e3c344ab91bf54150e31a34 FromRestList<T>(RestList<T> restList, Func <T, RC_5404698ef74632f0bc59763509d95177> converter) {
  RL_d8bc800f4e3c344ab91bf54150e31a34 result = new RL_d8bc800f4e3c344ab91bf54150e31a34();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d8bc800f4e3c344ab91bf54150e31a34() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(26,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5404698ef74632f0bc59763509d95177> NewList() {
return new RL_d8bc800f4e3c344ab91bf54150e31a34();
}


} // RL_d8bc800f4e3c344ab91bf54150e31a34
}

