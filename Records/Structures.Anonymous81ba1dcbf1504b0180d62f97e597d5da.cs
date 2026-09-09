namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (yx26gVDxAUuA1i+X5ZfV2g)
///  <code>RC_da31ba4ed131103eb5a5b5464cca7643</code> that represent
/// s <code>RequisitionApprovalLevelIdRequisitionIdRequisitionNameIsAccountingIsSelectedRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: RequisitionApprovalLevelIdRequisitionIdRequisitionNameIsAccountingIsSelectedRecord
public partial struct RC_da31ba4ed131103eb5a5b5464cca7643 : ITypedRecord<RC_da31ba4ed131103eb5a5b5464cca7643> {
internal static readonly GlobalObjectKey IdRequisitionApprovalLevelId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*N0v8d65GJ4c7XItBwHWMfA");
internal static readonly GlobalObjectKey IdRequisitionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*J18TAFPuqiB_fTqS+Z82nQ");
internal static readonly GlobalObjectKey IdRequisitionName = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OxQxVzV6jQEuz8WCLNYl9g");
internal static readonly GlobalObjectKey IdIsAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ox99coeuOnxY61pNuNVXMQ");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osqdCCbTPm0O_HzjZIVgPA");

public long ssRequisitionApprovalLevelId;

public long ssRequisitionId;

public string ssRequisitionName;

public bool ssIsAccounting;

public bool ssIsSelected;


public BitArray OptimizedAttributes;

public RC_da31ba4ed131103eb5a5b5464cca7643() {
OptimizedAttributes = null;
ssRequisitionApprovalLevelId = 0L;
ssRequisitionId = 0L;
ssRequisitionName = "";
ssIsAccounting = false;
ssIsSelected = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssRequisitionApprovalLevelId = r.ReadEntityReferenceLongInteger(index++, "RequisitionApprovalLevelIdRequisitionIdRequisitionNameIsAccountingIsSelectedRecord.RequisitionApprovalLevelId", 0L);
ssRequisitionId = r.ReadEntityReferenceLongInteger(index++, "RequisitionApprovalLevelIdRequisitionIdRequisitionNameIsAccountingIsSelectedRecord.RequisitionId", 0L);
ssRequisitionName = r.ReadText(index++, "RequisitionApprovalLevelIdRequisitionIdRequisitionNameIsAccountingIsSelectedRecord.RequisitionName", "");
ssIsAccounting = r.ReadBoolean(index++, "RequisitionApprovalLevelIdRequisitionIdRequisitionNameIsAccountingIsSelectedRecord.IsAccounting", false);
ssIsSelected = r.ReadBoolean(index++, "RequisitionApprovalLevelIdRequisitionIdRequisitionNameIsAccountingIsSelectedRecord.IsSelected", false);
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
public void ReadIM(RC_da31ba4ed131103eb5a5b5464cca7643 r) {
this = r;
}


public static bool operator == (RC_da31ba4ed131103eb5a5b5464cca7643 a, RC_da31ba4ed131103eb5a5b5464cca7643 b) {
if (a.ssRequisitionApprovalLevelId != b.ssRequisitionApprovalLevelId) return false;
if (a.ssRequisitionId != b.ssRequisitionId) return false;
if (a.ssRequisitionName != b.ssRequisitionName) return false;
if (a.ssIsAccounting != b.ssIsAccounting) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
return true;
}

public static bool operator != (RC_da31ba4ed131103eb5a5b5464cca7643 a, RC_da31ba4ed131103eb5a5b5464cca7643 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_da31ba4ed131103eb5a5b5464cca7643)) return false;
return (this == (RC_da31ba4ed131103eb5a5b5464cca7643)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssRequisitionApprovalLevelId.GetHashCode()
 ^ ssRequisitionId.GetHashCode()
 ^ ssRequisitionName.GetHashCode()
 ^ ssIsAccounting.GetHashCode()
 ^ ssIsSelected.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_da31ba4ed131103eb5a5b5464cca7643 Duplicate() {
RC_da31ba4ed131103eb5a5b5464cca7643 t;
t.ssRequisitionApprovalLevelId = this.ssRequisitionApprovalLevelId;
t.ssRequisitionId = this.ssRequisitionId;
t.ssRequisitionName = this.ssRequisitionName;
t.ssIsAccounting = this.ssIsAccounting;
t.ssIsSelected = this.ssIsSelected;
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
if (head == "requisitionapprovallevelid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionApprovalLevelId")) variable.Value = ssRequisitionApprovalLevelId; else variable.Optimized = true;
} else if (head == "requisitionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionId")) variable.Value = ssRequisitionId; else variable.Optimized = true;
} else if (head == "requisitionname") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionName")) variable.Value = ssRequisitionName; else variable.Optimized = true;
} else if (head == "isaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsAccounting")) variable.Value = ssIsAccounting; else variable.Optimized = true;
} else if (head == "isselected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSelected")) variable.Value = ssIsSelected; else variable.Optimized = true;
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
if (key == IdRequisitionApprovalLevelId) {
return ssRequisitionApprovalLevelId;
}
if (key == IdRequisitionId) {
return ssRequisitionId;
}
if (key == IdRequisitionName) {
return ssRequisitionName;
}
if (key == IdIsAccounting) {
return ssIsAccounting;
}
if (key == IdIsSelected) {
return ssIsSelected;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionApprovalLevelId.Key.AsGuid) {
return ssRequisitionApprovalLevelId;
}
if (attributeKey == IdRequisitionId.Key.AsGuid) {
return ssRequisitionId;
}
if (attributeKey == IdRequisitionName.Key.AsGuid) {
return ssRequisitionName;
}
if (attributeKey == IdIsAccounting.Key.AsGuid) {
return ssIsAccounting;
}
if (attributeKey == IdIsSelected.Key.AsGuid) {
return ssIsSelected;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssRequisitionApprovalLevelId = (long) other.AttributeGet(IdRequisitionApprovalLevelId);
ssRequisitionId = (long) other.AttributeGet(IdRequisitionId);
ssRequisitionName = (string) other.AttributeGet(IdRequisitionName);
ssIsAccounting = (bool) other.AttributeGet(IdIsAccounting);
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
}
} // RC_da31ba4ed131103eb5a5b5464cca7643
/// <summary>
/// RecordList type
///  <code>RequisitionApprovalLevelIdRequisitionIdRequisitionNameIsAccountingIsSelectedRecordList</code
/// > that represents a record list of <code>RequisitionApprovalLevelIdentifier, RequisitionIdentifier,
///  Text, Boolean, Boolean</code>
/// </summary>
public partial class RL_6f013a7f2ef00b964b6e71f1ec07b189 : GenericRecordList<RC_da31ba4ed131103eb5a5b5464cca7643>, IEnumerable, IEnumerator {

protected override RC_da31ba4ed131103eb5a5b5464cca7643 GetElementDefaultValue() {
return new RC_da31ba4ed131103eb5a5b5464cca7643();
}

public T[] ToArray<T>(Func<RC_da31ba4ed131103eb5a5b5464cca7643, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6f013a7f2ef00b964b6e71f1ec07b189 recordList, Func<RC_da31ba4ed131103eb5a5b5464cca7643, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6f013a7f2ef00b964b6e71f1ec07b189(RC_da31ba4ed131103eb5a5b5464cca7643[] array) {
  RL_6f013a7f2ef00b964b6e71f1ec07b189 result = new RL_6f013a7f2ef00b964b6e71f1ec07b189();
result.InnerFromArray(array);
    return result;
}

public static RL_6f013a7f2ef00b964b6e71f1ec07b189 ToList<T>(T[] array, Func <T, RC_da31ba4ed131103eb5a5b5464cca7643> converter) {
  RL_6f013a7f2ef00b964b6e71f1ec07b189 result = new RL_6f013a7f2ef00b964b6e71f1ec07b189();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6f013a7f2ef00b964b6e71f1ec07b189 FromRestList<T>(RestList<T> restList, Func <T, RC_da31ba4ed131103eb5a5b5464cca7643> converter) {
  RL_6f013a7f2ef00b964b6e71f1ec07b189 result = new RL_6f013a7f2ef00b964b6e71f1ec07b189();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6f013a7f2ef00b964b6e71f1ec07b189() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_da31ba4ed131103eb5a5b5464cca7643> NewList() {
return new RL_6f013a7f2ef00b964b6e71f1ec07b189();
}


} // RL_6f013a7f2ef00b964b6e71f1ec07b189
}

