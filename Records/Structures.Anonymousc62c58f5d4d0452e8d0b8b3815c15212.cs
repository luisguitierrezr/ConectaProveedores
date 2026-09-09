namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (9VgsxtDULkWNC4s4FcFSEg)
///  <code>RC_cc5b09a13023b24fea23c488b525369e</code> that represent
/// s <code>RequisitionCostCenterSAPRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionCostCenterSAPRecord
public partial struct RC_cc5b09a13023b24fea23c488b525369e : ITypedRecord<RC_cc5b09a13023b24fea23c488b525369e> {
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D5VeUbLkBpJ2nlR1E14wHQ");

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCostCenterSAP;


public BitArray OptimizedAttributes;

public RC_cc5b09a13023b24fea23c488b525369e() {
OptimizedAttributes = null;
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(58,false);
    all[1] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENRequisition.OptimizedAttributes = value[0];
    ssENCostCenterSAP.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENRequisition.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
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
public void ReadIM(RC_cc5b09a13023b24fea23c488b525369e r) {
this = r;
}


public static bool operator == (RC_cc5b09a13023b24fea23c488b525369e a, RC_cc5b09a13023b24fea23c488b525369e b) {
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENCostCenterSAP != b.ssENCostCenterSAP) return false;
return true;
}

public static bool operator != (RC_cc5b09a13023b24fea23c488b525369e a, RC_cc5b09a13023b24fea23c488b525369e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_cc5b09a13023b24fea23c488b525369e)) return false;
return (this == (RC_cc5b09a13023b24fea23c488b525369e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENCostCenterSAP.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisition.RecursiveReset();
ssENCostCenterSAP.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisition.InternalRecursiveSave();
ssENCostCenterSAP.InternalRecursiveSave();
}


public RC_cc5b09a13023b24fea23c488b525369e Duplicate() {
RC_cc5b09a13023b24fea23c488b525369e t;
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
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
if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdCostCenterSAP) {
return ssENCostCenterSAP;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdCostCenterSAP.Key.AsGuid) {
return ssENCostCenterSAP;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCostCenterSAP));
}
} // RC_cc5b09a13023b24fea23c488b525369e
/// <summary>
/// RecordList type <code>RequisitionCostCenterSAPRecordList</code> that represents a record list of
///  <code>Requisition, CostCenterSAP</code>
/// </summary>
public partial class RL_40d1dae5da886b385f88ea5c5c7574ca : GenericRecordList<RC_cc5b09a13023b24fea23c488b525369e>, IEnumerable, IEnumerator {

protected override RC_cc5b09a13023b24fea23c488b525369e GetElementDefaultValue() {
return new RC_cc5b09a13023b24fea23c488b525369e();
}

public T[] ToArray<T>(Func<RC_cc5b09a13023b24fea23c488b525369e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_40d1dae5da886b385f88ea5c5c7574ca recordList, Func<RC_cc5b09a13023b24fea23c488b525369e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_40d1dae5da886b385f88ea5c5c7574ca(RC_cc5b09a13023b24fea23c488b525369e[] array) {
  RL_40d1dae5da886b385f88ea5c5c7574ca result = new RL_40d1dae5da886b385f88ea5c5c7574ca();
result.InnerFromArray(array);
    return result;
}

public static RL_40d1dae5da886b385f88ea5c5c7574ca ToList<T>(T[] array, Func <T, RC_cc5b09a13023b24fea23c488b525369e> converter) {
  RL_40d1dae5da886b385f88ea5c5c7574ca result = new RL_40d1dae5da886b385f88ea5c5c7574ca();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_40d1dae5da886b385f88ea5c5c7574ca FromRestList<T>(RestList<T> restList, Func <T, RC_cc5b09a13023b24fea23c488b525369e> converter) {
  RL_40d1dae5da886b385f88ea5c5c7574ca result = new RL_40d1dae5da886b385f88ea5c5c7574ca();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_40d1dae5da886b385f88ea5c5c7574ca() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(58,false);
def[1] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_cc5b09a13023b24fea23c488b525369e> NewList() {
return new RL_40d1dae5da886b385f88ea5c5c7574ca();
}


} // RL_40d1dae5da886b385f88ea5c5c7574ca
}

