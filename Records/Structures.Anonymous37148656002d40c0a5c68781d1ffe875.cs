namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (VoYUNy0AwEClxoeB0f_odQ)
///  <code>RC_ba1b673fb7796808ead75722c028b587</code> that represent
/// s <code>RequisitionApprovalLevelRequisitionApprovalApplicationRoleRecord</code> <p>Description:
///  </p>
/// </summary>
// Name: RequisitionApprovalLevelRequisitionApprovalApplicationRoleRecord
public partial struct RC_ba1b673fb7796808ead75722c028b587 : ITypedRecord<RC_ba1b673fb7796808ead75722c028b587> {
internal static readonly GlobalObjectKey IdRequisitionApprovalLevel = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*jmkEVEb38DK8WXY1CdlRdw");
internal static readonly GlobalObjectKey IdRequisitionApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*S+8rbTJ+TN58eIhu7_dSJA");
internal static readonly GlobalObjectKey IdApplicationRole = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Q0fszuVdwmNpC2BezKaalA");

public EN_27b1469f497d364a764a1359956ef9adEntityRecord ssENRequisitionApprovalLevel;

public EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord ssENRequisitionApproval;

public EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord ssENApplicationRole;


public BitArray OptimizedAttributes;

public RC_ba1b673fb7796808ead75722c028b587() {
OptimizedAttributes = null;
ssENRequisitionApprovalLevel = new EN_27b1469f497d364a764a1359956ef9adEntityRecord();
ssENRequisitionApproval = new EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord();
ssENApplicationRole = new EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(26,false);
    all[1] = new BitArray(10,false);
    all[2] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionApprovalLevel.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENRequisitionApproval.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENApplicationRole.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENRequisitionApprovalLevel.OptimizedAttributes = value[0];
    ssENRequisitionApproval.OptimizedAttributes = value[1];
    ssENApplicationRole.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENRequisitionApprovalLevel.OptimizedAttributes;
    all[1] = ssENRequisitionApproval.OptimizedAttributes;
    all[2] = ssENApplicationRole.OptimizedAttributes;
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
ssENRequisitionApproval.Read( r, ref index);
ssENApplicationRole.Read( r, ref index);
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
public void ReadIM(RC_ba1b673fb7796808ead75722c028b587 r) {
this = r;
}


public static bool operator == (RC_ba1b673fb7796808ead75722c028b587 a, RC_ba1b673fb7796808ead75722c028b587 b) {
if (a.ssENRequisitionApprovalLevel != b.ssENRequisitionApprovalLevel) return false;
if (a.ssENRequisitionApproval != b.ssENRequisitionApproval) return false;
if (a.ssENApplicationRole != b.ssENApplicationRole) return false;
return true;
}

public static bool operator != (RC_ba1b673fb7796808ead75722c028b587 a, RC_ba1b673fb7796808ead75722c028b587 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ba1b673fb7796808ead75722c028b587)) return false;
return (this == (RC_ba1b673fb7796808ead75722c028b587)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionApprovalLevel.GetHashCode()
 ^ ssENRequisitionApproval.GetHashCode()
 ^ ssENApplicationRole.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionApprovalLevel.RecursiveReset();
ssENRequisitionApproval.RecursiveReset();
ssENApplicationRole.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionApprovalLevel.InternalRecursiveSave();
ssENRequisitionApproval.InternalRecursiveSave();
ssENApplicationRole.InternalRecursiveSave();
}


public RC_ba1b673fb7796808ead75722c028b587 Duplicate() {
RC_ba1b673fb7796808ead75722c028b587 t;
t.ssENRequisitionApprovalLevel = (EN_27b1469f497d364a764a1359956ef9adEntityRecord)this.ssENRequisitionApprovalLevel.Duplicate();
t.ssENRequisitionApproval = (EN_6c5158a8c0b1378d4d388705cd49d1e4EntityRecord)this.ssENRequisitionApproval.Duplicate();
t.ssENApplicationRole = (EN_5101e0ab6c96f7ba3807b0ab86290b1aEntityRecord)this.ssENApplicationRole.Duplicate();
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
} else if (head == "requisitionapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApproval")) variable.Value = ssENRequisitionApproval; else variable.Optimized = true;
variable.SetFieldName("requisitionapproval");
} else if (head == "applicationrole") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ApplicationRole")) variable.Value = ssENApplicationRole; else variable.Optimized = true;
variable.SetFieldName("applicationrole");
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
if (key == IdRequisitionApprovalLevel) {
return ssENRequisitionApprovalLevel;
}
if (key == IdRequisitionApproval) {
return ssENRequisitionApproval;
}
if (key == IdApplicationRole) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionApprovalLevel.Key.AsGuid) {
return ssENRequisitionApprovalLevel;
}
if (attributeKey == IdRequisitionApproval.Key.AsGuid) {
return ssENRequisitionApproval;
}
if (attributeKey == IdApplicationRole.Key.AsGuid) {
return ssENApplicationRole;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionApprovalLevel.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApprovalLevel));
ssENRequisitionApproval.FillFromOther((IRecord) other.AttributeGet(IdRequisitionApproval));
ssENApplicationRole.FillFromOther((IRecord) other.AttributeGet(IdApplicationRole));
}
} // RC_ba1b673fb7796808ead75722c028b587
/// <summary>
/// RecordList type <code>RequisitionApprovalLevelRequisitionApprovalApplicationRoleRecordList</code>
///  that represents a record list of <code>RequisitionApprovalLevel, RequisitionApproval
/// , ApplicationRole</code>
/// </summary>
public partial class RL_afae8d527b0040f7963527494bd77f34 : GenericRecordList<RC_ba1b673fb7796808ead75722c028b587>, IEnumerable, IEnumerator {

protected override RC_ba1b673fb7796808ead75722c028b587 GetElementDefaultValue() {
return new RC_ba1b673fb7796808ead75722c028b587();
}

public T[] ToArray<T>(Func<RC_ba1b673fb7796808ead75722c028b587, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_afae8d527b0040f7963527494bd77f34 recordList, Func<RC_ba1b673fb7796808ead75722c028b587, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_afae8d527b0040f7963527494bd77f34(RC_ba1b673fb7796808ead75722c028b587[] array) {
  RL_afae8d527b0040f7963527494bd77f34 result = new RL_afae8d527b0040f7963527494bd77f34();
result.InnerFromArray(array);
    return result;
}

public static RL_afae8d527b0040f7963527494bd77f34 ToList<T>(T[] array, Func <T, RC_ba1b673fb7796808ead75722c028b587> converter) {
  RL_afae8d527b0040f7963527494bd77f34 result = new RL_afae8d527b0040f7963527494bd77f34();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_afae8d527b0040f7963527494bd77f34 FromRestList<T>(RestList<T> restList, Func <T, RC_ba1b673fb7796808ead75722c028b587> converter) {
  RL_afae8d527b0040f7963527494bd77f34 result = new RL_afae8d527b0040f7963527494bd77f34();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_afae8d527b0040f7963527494bd77f34() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(26,false);
def[1] = new BitArray(10,false);
def[2] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_ba1b673fb7796808ead75722c028b587> NewList() {
return new RL_afae8d527b0040f7963527494bd77f34();
}


} // RL_afae8d527b0040f7963527494bd77f34
}

