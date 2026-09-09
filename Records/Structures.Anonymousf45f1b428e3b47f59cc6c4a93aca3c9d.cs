namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Qhtf9DuO9UecxsSpOso8nQ)
///  <code>RC_f5b6f78be278df3dd44e2d0a42d99692</code> that represent
/// s <code>UserRequisitionLogsRequisitionRecord</code> <p>Description: </p>
/// </summary>
// Name: UserRequisitionLogsRequisitionRecord
public partial struct RC_f5b6f78be278df3dd44e2d0a42d99692 : ITypedRecord<RC_f5b6f78be278df3dd44e2d0a42d99692> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdRequisitionLogs = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*JzUC2nZ1Kn1X6kzTXNGElg");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");

public ENUserEntityRecord ssENUser;

public EN_fca813b8ca96d6759e00225744caa7d4EntityRecord ssENRequisitionLogs;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;


public BitArray OptimizedAttributes;

public RC_f5b6f78be278df3dd44e2d0a42d99692() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENRequisitionLogs = new EN_fca813b8ca96d6759e00225744caa7d4EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(6,false);
    all[2] = new BitArray(58,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionLogs.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENRequisitionLogs.OptimizedAttributes = value[1];
    ssENRequisition.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENRequisitionLogs.OptimizedAttributes;
    all[2] = ssENRequisition.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENRequisitionLogs.Read( r, ref index);
ssENRequisition.Read( r, ref index);
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
public void ReadIM(RC_f5b6f78be278df3dd44e2d0a42d99692 r) {
this = r;
}


public static bool operator == (RC_f5b6f78be278df3dd44e2d0a42d99692 a, RC_f5b6f78be278df3dd44e2d0a42d99692 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENRequisitionLogs != b.ssENRequisitionLogs) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
return true;
}

public static bool operator != (RC_f5b6f78be278df3dd44e2d0a42d99692 a, RC_f5b6f78be278df3dd44e2d0a42d99692 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f5b6f78be278df3dd44e2d0a42d99692)) return false;
return (this == (RC_f5b6f78be278df3dd44e2d0a42d99692)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENRequisitionLogs.GetHashCode()
 ^ ssENRequisition.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENRequisitionLogs.RecursiveReset();
ssENRequisition.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENRequisitionLogs.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
}


public RC_f5b6f78be278df3dd44e2d0a42d99692 Duplicate() {
RC_f5b6f78be278df3dd44e2d0a42d99692 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENRequisitionLogs = (EN_fca813b8ca96d6759e00225744caa7d4EntityRecord)this.ssENRequisitionLogs.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "requisitionlogs") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionLogs")) variable.Value = ssENRequisitionLogs; else variable.Optimized = true;
variable.SetFieldName("requisitionlogs");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdRequisitionLogs) {
return ssENRequisitionLogs;
}
if (key == IdRequisition) {
return ssENRequisition;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdRequisitionLogs.Key.AsGuid) {
return ssENRequisitionLogs;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENRequisitionLogs.FillFromOther((IRecord) other.AttributeGet(IdRequisitionLogs));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
}
} // RC_f5b6f78be278df3dd44e2d0a42d99692
/// <summary>
/// RecordList type <code>UserRequisitionLogsRequisitionRecordList</code> that represents a record list
///  of <code>User, RequisitionLogs, Requisition</code>
/// </summary>
public partial class RL_229a538de0ea5acc5992a93132dd8a21 : GenericRecordList<RC_f5b6f78be278df3dd44e2d0a42d99692>, IEnumerable, IEnumerator {

protected override RC_f5b6f78be278df3dd44e2d0a42d99692 GetElementDefaultValue() {
return new RC_f5b6f78be278df3dd44e2d0a42d99692();
}

public T[] ToArray<T>(Func<RC_f5b6f78be278df3dd44e2d0a42d99692, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_229a538de0ea5acc5992a93132dd8a21 recordList, Func<RC_f5b6f78be278df3dd44e2d0a42d99692, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_229a538de0ea5acc5992a93132dd8a21(RC_f5b6f78be278df3dd44e2d0a42d99692[] array) {
  RL_229a538de0ea5acc5992a93132dd8a21 result = new RL_229a538de0ea5acc5992a93132dd8a21();
result.InnerFromArray(array);
    return result;
}

public static RL_229a538de0ea5acc5992a93132dd8a21 ToList<T>(T[] array, Func <T, RC_f5b6f78be278df3dd44e2d0a42d99692> converter) {
  RL_229a538de0ea5acc5992a93132dd8a21 result = new RL_229a538de0ea5acc5992a93132dd8a21();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_229a538de0ea5acc5992a93132dd8a21 FromRestList<T>(RestList<T> restList, Func <T, RC_f5b6f78be278df3dd44e2d0a42d99692> converter) {
  RL_229a538de0ea5acc5992a93132dd8a21 result = new RL_229a538de0ea5acc5992a93132dd8a21();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_229a538de0ea5acc5992a93132dd8a21() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(6,false);
def[2] = new BitArray(58,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f5b6f78be278df3dd44e2d0a42d99692> NewList() {
return new RL_229a538de0ea5acc5992a93132dd8a21();
}


} // RL_229a538de0ea5acc5992a93132dd8a21
}

