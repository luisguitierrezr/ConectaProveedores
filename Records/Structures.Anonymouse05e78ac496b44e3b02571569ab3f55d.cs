namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (rHhe4GtJ40SwJXFWmrP1XQ)
///  <code>RC_04e7247757060d4016b43102119b0dd6</code> that represent
/// s <code>RequisitionServiceRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionServiceRecord
public partial struct RC_04e7247757060d4016b43102119b0dd6 : ITypedRecord<RC_04e7247757060d4016b43102119b0dd6> {
internal static readonly GlobalObjectKey IdRequisitionService = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dyTnBAZXQA0WtDECEZsN1g");

public EN_455768e63ed34ad2746f7c539b65e1caEntityRecord ssENRequisitionService;


public static implicit operator EN_455768e63ed34ad2746f7c539b65e1caEntityRecord( RC_04e7247757060d4016b43102119b0dd6 r) {
return r.ssENRequisitionService;
}

public static implicit operator RC_04e7247757060d4016b43102119b0dd6 (EN_455768e63ed34ad2746f7c539b65e1caEntityRecord r) {
RC_04e7247757060d4016b43102119b0dd6 res = new RC_04e7247757060d4016b43102119b0dd6 ();
res.ssENRequisitionService = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisitionService.ChangedAttributes = value;
}
get {
    return ssENRequisitionService.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_04e7247757060d4016b43102119b0dd6() {
OptimizedAttributes = null;
ssENRequisitionService = new EN_455768e63ed34ad2746f7c539b65e1caEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionService.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisitionService.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisitionService.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionService.Read( r, ref index);
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
public void ReadIM(RC_04e7247757060d4016b43102119b0dd6 r) {
this = r;
}


public static bool operator == (RC_04e7247757060d4016b43102119b0dd6 a, RC_04e7247757060d4016b43102119b0dd6 b) {
if (a.ssENRequisitionService != b.ssENRequisitionService) return false;
return true;
}

public static bool operator != (RC_04e7247757060d4016b43102119b0dd6 a, RC_04e7247757060d4016b43102119b0dd6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_04e7247757060d4016b43102119b0dd6)) return false;
return (this == (RC_04e7247757060d4016b43102119b0dd6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionService.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionService.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionService.InternalRecursiveSave();
}


public RC_04e7247757060d4016b43102119b0dd6 Duplicate() {
RC_04e7247757060d4016b43102119b0dd6 t;
t.ssENRequisitionService = (EN_455768e63ed34ad2746f7c539b65e1caEntityRecord)this.ssENRequisitionService.Duplicate();
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
if (head == "requisitionservice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionService")) variable.Value = ssENRequisitionService; else variable.Optimized = true;
variable.SetFieldName("requisitionservice");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionService.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionService.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisitionService) {
return ssENRequisitionService;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionService.Key.AsGuid) {
return ssENRequisitionService;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionService.FillFromOther((IRecord) other.AttributeGet(IdRequisitionService));
}
} // RC_04e7247757060d4016b43102119b0dd6
/// <summary>
/// RecordList type <code>RequisitionServiceRecordList</code> that represents a record list of
///  <code>RequisitionService</code>
/// </summary>
public partial class RL_b47d9310671b1b627f451a333bb8980a : GenericRecordList<RC_04e7247757060d4016b43102119b0dd6>, IEnumerable, IEnumerator {

protected override RC_04e7247757060d4016b43102119b0dd6 GetElementDefaultValue() {
return new RC_04e7247757060d4016b43102119b0dd6();
}

public T[] ToArray<T>(Func<RC_04e7247757060d4016b43102119b0dd6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_b47d9310671b1b627f451a333bb8980a recordList, Func<RC_04e7247757060d4016b43102119b0dd6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_b47d9310671b1b627f451a333bb8980a(RC_04e7247757060d4016b43102119b0dd6[] array) {
  RL_b47d9310671b1b627f451a333bb8980a result = new RL_b47d9310671b1b627f451a333bb8980a();
result.InnerFromArray(array);
    return result;
}

public static RL_b47d9310671b1b627f451a333bb8980a ToList<T>(T[] array, Func <T, RC_04e7247757060d4016b43102119b0dd6> converter) {
  RL_b47d9310671b1b627f451a333bb8980a result = new RL_b47d9310671b1b627f451a333bb8980a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_b47d9310671b1b627f451a333bb8980a FromRestList<T>(RestList<T> restList, Func <T, RC_04e7247757060d4016b43102119b0dd6> converter) {
  RL_b47d9310671b1b627f451a333bb8980a result = new RL_b47d9310671b1b627f451a333bb8980a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_b47d9310671b1b627f451a333bb8980a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_04e7247757060d4016b43102119b0dd6> NewList() {
return new RL_b47d9310671b1b627f451a333bb8980a();
}


} // RL_b47d9310671b1b627f451a333bb8980a
}

