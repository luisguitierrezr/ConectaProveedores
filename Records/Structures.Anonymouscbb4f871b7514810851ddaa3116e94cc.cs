namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (cfi0y1G3EEiFHdqjEW6UzA)
///  <code>RC_7c130c22cc39a396afe0c98666f27e02</code> that represent
/// s <code>RequisitionCostCenterCostCenterSAPRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionCostCenterCostCenterSAPRecord
public partial struct RC_7c130c22cc39a396afe0c98666f27e02 : ITypedRecord<RC_7c130c22cc39a396afe0c98666f27e02> {
internal static readonly GlobalObjectKey IdRequisitionCostCenter = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*mFWDUDYKr3aUaBmRS2sVRg");
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D5VeUbLkBpJ2nlR1E14wHQ");

public EN_114fcf95674648310a3efb0d78529a37EntityRecord ssENRequisitionCostCenter;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCostCenterSAP;


public BitArray OptimizedAttributes;

public RC_7c130c22cc39a396afe0c98666f27e02() {
OptimizedAttributes = null;
ssENRequisitionCostCenter = new EN_114fcf95674648310a3efb0d78529a37EntityRecord();
ssENCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(3,false);
    all[1] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionCostCenter.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisitionCostCenter.OptimizedAttributes = value[0];
    ssENCostCenterSAP.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisitionCostCenter.OptimizedAttributes;
    all[1] = ssENCostCenterSAP.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionCostCenter.Read( r, ref index);
ssENCostCenterSAP.Read( r, ref index);
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
public void ReadIM(RC_7c130c22cc39a396afe0c98666f27e02 r) {
this = r;
}


public static bool operator == (RC_7c130c22cc39a396afe0c98666f27e02 a, RC_7c130c22cc39a396afe0c98666f27e02 b) {
if (a.ssENRequisitionCostCenter != b.ssENRequisitionCostCenter) return false;
if (a.ssENCostCenterSAP != b.ssENCostCenterSAP) return false;
return true;
}

public static bool operator != (RC_7c130c22cc39a396afe0c98666f27e02 a, RC_7c130c22cc39a396afe0c98666f27e02 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_7c130c22cc39a396afe0c98666f27e02)) return false;
return (this == (RC_7c130c22cc39a396afe0c98666f27e02)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionCostCenter.GetHashCode()
 ^ ssENCostCenterSAP.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionCostCenter.RecursiveReset();
ssENCostCenterSAP.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionCostCenter.InternalRecursiveSave();
ssENCostCenterSAP.InternalRecursiveSave();
}


public RC_7c130c22cc39a396afe0c98666f27e02 Duplicate() {
RC_7c130c22cc39a396afe0c98666f27e02 t;
t.ssENRequisitionCostCenter = (EN_114fcf95674648310a3efb0d78529a37EntityRecord)this.ssENRequisitionCostCenter.Duplicate();
t.ssENCostCenterSAP = (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord)this.ssENCostCenterSAP.Duplicate();
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
if (head == "requisitioncostcenter") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionCostCenter")) variable.Value = ssENRequisitionCostCenter; else variable.Optimized = true;
variable.SetFieldName("requisitioncostcenter");
} else if (head == "costcentersap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterSAP")) variable.Value = ssENCostCenterSAP; else variable.Optimized = true;
variable.SetFieldName("costcentersap");
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
if (key == IdRequisitionCostCenter) {
return ssENRequisitionCostCenter;
}
if (key == IdCostCenterSAP) {
return ssENCostCenterSAP;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionCostCenter.Key.AsGuid) {
return ssENRequisitionCostCenter;
}
if (attributeKey == IdCostCenterSAP.Key.AsGuid) {
return ssENCostCenterSAP;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionCostCenter.FillFromOther((IRecord) other.AttributeGet(IdRequisitionCostCenter));
ssENCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCostCenterSAP));
}
} // RC_7c130c22cc39a396afe0c98666f27e02
/// <summary>
/// RecordList type <code>RequisitionCostCenterCostCenterSAPRecordList</code> that represents a record
///  list of <code>RequisitionCostCenter, CostCenterSAP</code>
/// </summary>
public partial class RL_a3213f63c9dee3312d82d37ec604d349 : GenericRecordList<RC_7c130c22cc39a396afe0c98666f27e02>, IEnumerable, IEnumerator {

protected override RC_7c130c22cc39a396afe0c98666f27e02 GetElementDefaultValue() {
return new RC_7c130c22cc39a396afe0c98666f27e02();
}

public T[] ToArray<T>(Func<RC_7c130c22cc39a396afe0c98666f27e02, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a3213f63c9dee3312d82d37ec604d349 recordList, Func<RC_7c130c22cc39a396afe0c98666f27e02, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a3213f63c9dee3312d82d37ec604d349(RC_7c130c22cc39a396afe0c98666f27e02[] array) {
  RL_a3213f63c9dee3312d82d37ec604d349 result = new RL_a3213f63c9dee3312d82d37ec604d349();
result.InnerFromArray(array);
    return result;
}

public static RL_a3213f63c9dee3312d82d37ec604d349 ToList<T>(T[] array, Func <T, RC_7c130c22cc39a396afe0c98666f27e02> converter) {
  RL_a3213f63c9dee3312d82d37ec604d349 result = new RL_a3213f63c9dee3312d82d37ec604d349();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a3213f63c9dee3312d82d37ec604d349 FromRestList<T>(RestList<T> restList, Func <T, RC_7c130c22cc39a396afe0c98666f27e02> converter) {
  RL_a3213f63c9dee3312d82d37ec604d349 result = new RL_a3213f63c9dee3312d82d37ec604d349();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a3213f63c9dee3312d82d37ec604d349() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(3,false);
def[1] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_7c130c22cc39a396afe0c98666f27e02> NewList() {
return new RL_a3213f63c9dee3312d82d37ec604d349();
}


} // RL_a3213f63c9dee3312d82d37ec604d349
}

