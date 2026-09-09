namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (9hXSZwamQk+PYNa6RHxc7A)
///  <code>RC_89706669e1ea39d5a8170d632a3a45dc</code> that represent
/// s <code>OrdersImportRequestOrderApprovalOrderApprovalLevelRecord</code> <p>Description: </p>
/// </summary>
// Name: OrdersImportRequestOrderApprovalOrderApprovalLevelRecord
public partial struct RC_89706669e1ea39d5a8170d632a3a45dc : ITypedRecord<RC_89706669e1ea39d5a8170d632a3a45dc> {
internal static readonly GlobalObjectKey IdOrdersImportRequest = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*q7UHJMuyrv6qjabN6kzPEg");
internal static readonly GlobalObjectKey IdOrderApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ix+DUUC_iYaxlr5dujqR6g");
internal static readonly GlobalObjectKey IdOrderApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*u4KD_7ZvfcxX7Np7tJmSLw");

public EN_8c3668a93870461b8ea1216c2848f298EntityRecord ssENOrdersImportRequest;

public EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord ssENOrderApproval;

public EN_6b660d05e4c0025dff47119642875ca2EntityRecord ssENOrderApprovalLevel;


public BitArray OptimizedAttributes;

public RC_89706669e1ea39d5a8170d632a3a45dc() {
OptimizedAttributes = null;
ssENOrdersImportRequest = new EN_8c3668a93870461b8ea1216c2848f298EntityRecord();
ssENOrderApproval = new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord();
ssENOrderApprovalLevel = new EN_6b660d05e4c0025dff47119642875ca2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(10,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(17,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrdersImportRequest.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENOrderApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENOrderApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENOrdersImportRequest.OptimizedAttributes = value[0];
    ssENOrderApproval.OptimizedAttributes = value[1];
    ssENOrderApprovalLevel.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENOrdersImportRequest.OptimizedAttributes;
    all[1] = ssENOrderApproval.OptimizedAttributes;
    all[2] = ssENOrderApprovalLevel.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrdersImportRequest.Read( r, ref index);
ssENOrderApproval.Read( r, ref index);
ssENOrderApprovalLevel.Read( r, ref index);
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
public void ReadIM(RC_89706669e1ea39d5a8170d632a3a45dc r) {
this = r;
}


public static bool operator == (RC_89706669e1ea39d5a8170d632a3a45dc a, RC_89706669e1ea39d5a8170d632a3a45dc b) {
if (a.ssENOrdersImportRequest != b.ssENOrdersImportRequest) return false;
if (a.ssENOrderApproval != b.ssENOrderApproval) return false;
if (a.ssENOrderApprovalLevel != b.ssENOrderApprovalLevel) return false;
return true;
}

public static bool operator != (RC_89706669e1ea39d5a8170d632a3a45dc a, RC_89706669e1ea39d5a8170d632a3a45dc b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_89706669e1ea39d5a8170d632a3a45dc)) return false;
return (this == (RC_89706669e1ea39d5a8170d632a3a45dc)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrdersImportRequest.GetHashCode()
 ^ ssENOrderApproval.GetHashCode()
 ^ ssENOrderApprovalLevel.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrdersImportRequest.RecursiveReset();
ssENOrderApproval.RecursiveReset();
ssENOrderApprovalLevel.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrdersImportRequest.InternalRecursiveSave();
ssENOrderApproval.InternalRecursiveSave();
ssENOrderApprovalLevel.InternalRecursiveSave();
}


public RC_89706669e1ea39d5a8170d632a3a45dc Duplicate() {
RC_89706669e1ea39d5a8170d632a3a45dc t;
t.ssENOrdersImportRequest = (EN_8c3668a93870461b8ea1216c2848f298EntityRecord)this.ssENOrdersImportRequest.Duplicate();
t.ssENOrderApproval = (EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord)this.ssENOrderApproval.Duplicate();
t.ssENOrderApprovalLevel = (EN_6b660d05e4c0025dff47119642875ca2EntityRecord)this.ssENOrderApprovalLevel.Duplicate();
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
if (head == "ordersimportrequest") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrdersImportRequest")) variable.Value = ssENOrdersImportRequest; else variable.Optimized = true;
variable.SetFieldName("ordersimportrequest");
} else if (head == "orderapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApproval")) variable.Value = ssENOrderApproval; else variable.Optimized = true;
variable.SetFieldName("orderapproval");
} else if (head == "orderapprovallevel") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderApprovalLevel")) variable.Value = ssENOrderApprovalLevel; else variable.Optimized = true;
variable.SetFieldName("orderapprovallevel");
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
if (key == IdOrdersImportRequest) {
return ssENOrdersImportRequest;
}
if (key == IdOrderApproval) {
return ssENOrderApproval;
}
if (key == IdOrderApprovalLevel) {
return ssENOrderApprovalLevel;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrdersImportRequest.Key.AsGuid) {
return ssENOrdersImportRequest;
}
if (attributeKey == IdOrderApproval.Key.AsGuid) {
return ssENOrderApproval;
}
if (attributeKey == IdOrderApprovalLevel.Key.AsGuid) {
return ssENOrderApprovalLevel;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrdersImportRequest.FillFromOther((IRecord) other.AttributeGet(IdOrdersImportRequest));
ssENOrderApproval.FillFromOther((IRecord) other.AttributeGet(IdOrderApproval));
ssENOrderApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdOrderApprovalLevel));
}
} // RC_89706669e1ea39d5a8170d632a3a45dc
/// <summary>
/// RecordList type <code>OrdersImportRequestOrderApprovalOrderApprovalLevelRecordList</code> that
///  represents a record list of <code>OrdersImportRequest, OrderApproval, OrderApprovalLevel</code>
/// </summary>
public partial class RL_586f7fa2a94434b7f9ecfc7c44eb315b : GenericRecordList<RC_89706669e1ea39d5a8170d632a3a45dc>, IEnumerable, IEnumerator {

protected override RC_89706669e1ea39d5a8170d632a3a45dc GetElementDefaultValue() {
return new RC_89706669e1ea39d5a8170d632a3a45dc();
}

public T[] ToArray<T>(Func<RC_89706669e1ea39d5a8170d632a3a45dc, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_586f7fa2a94434b7f9ecfc7c44eb315b recordList, Func<RC_89706669e1ea39d5a8170d632a3a45dc, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_586f7fa2a94434b7f9ecfc7c44eb315b(RC_89706669e1ea39d5a8170d632a3a45dc[] array) {
  RL_586f7fa2a94434b7f9ecfc7c44eb315b result = new RL_586f7fa2a94434b7f9ecfc7c44eb315b();
result.InnerFromArray(array);
    return result;
}

public static RL_586f7fa2a94434b7f9ecfc7c44eb315b ToList<T>(T[] array, Func <T, RC_89706669e1ea39d5a8170d632a3a45dc> converter) {
  RL_586f7fa2a94434b7f9ecfc7c44eb315b result = new RL_586f7fa2a94434b7f9ecfc7c44eb315b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_586f7fa2a94434b7f9ecfc7c44eb315b FromRestList<T>(RestList<T> restList, Func <T, RC_89706669e1ea39d5a8170d632a3a45dc> converter) {
  RL_586f7fa2a94434b7f9ecfc7c44eb315b result = new RL_586f7fa2a94434b7f9ecfc7c44eb315b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_586f7fa2a94434b7f9ecfc7c44eb315b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(10,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(17,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_89706669e1ea39d5a8170d632a3a45dc> NewList() {
return new RL_586f7fa2a94434b7f9ecfc7c44eb315b();
}


} // RL_586f7fa2a94434b7f9ecfc7c44eb315b
}

