namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (q0VU4FgXb0WDAkrCm+RODQ)
///  <code>RC_515e950fe4b29206769e5475135e301d</code> that represents <code>CostCenterSAPRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: CostCenterSAPRecord
public partial struct RC_515e950fe4b29206769e5475135e301d : ITypedRecord<RC_515e950fe4b29206769e5475135e301d> {
internal static readonly GlobalObjectKey IdCostCenterSAP = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*D5VeUbLkBpJ2nlR1E14wHQ");

public EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord ssENCostCenterSAP;


public static implicit operator EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord( RC_515e950fe4b29206769e5475135e301d r) {
return r.ssENCostCenterSAP;
}

public static implicit operator RC_515e950fe4b29206769e5475135e301d (EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord r) {
RC_515e950fe4b29206769e5475135e301d res = new RC_515e950fe4b29206769e5475135e301d ();
res.ssENCostCenterSAP = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENCostCenterSAP.ChangedAttributes = value;
}
get {
    return ssENCostCenterSAP.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_515e950fe4b29206769e5475135e301d() {
OptimizedAttributes = null;
ssENCostCenterSAP = new EN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(25,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCostCenterSAP.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENCostCenterSAP.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENCostCenterSAP.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
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
public void ReadIM(RC_515e950fe4b29206769e5475135e301d r) {
this = r;
}


public static bool operator == (RC_515e950fe4b29206769e5475135e301d a, RC_515e950fe4b29206769e5475135e301d b) {
if (a.ssENCostCenterSAP != b.ssENCostCenterSAP) return false;
return true;
}

public static bool operator != (RC_515e950fe4b29206769e5475135e301d a, RC_515e950fe4b29206769e5475135e301d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_515e950fe4b29206769e5475135e301d)) return false;
return (this == (RC_515e950fe4b29206769e5475135e301d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCostCenterSAP.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCostCenterSAP.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCostCenterSAP.InternalRecursiveSave();
}


public RC_515e950fe4b29206769e5475135e301d Duplicate() {
RC_515e950fe4b29206769e5475135e301d t;
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
if (head == "costcentersap") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CostCenterSAP")) variable.Value = ssENCostCenterSAP; else variable.Optimized = true;
variable.SetFieldName("costcentersap");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENCostCenterSAP.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENCostCenterSAP.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdCostCenterSAP) {
return ssENCostCenterSAP;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCostCenterSAP.Key.AsGuid) {
return ssENCostCenterSAP;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCostCenterSAP.FillFromOther((IRecord) other.AttributeGet(IdCostCenterSAP));
}
} // RC_515e950fe4b29206769e5475135e301d
/// <summary>
/// RecordList type <code>CostCenterSAPRecordList</code> that represents a record list of
///  <code>CostCenterSAP</code>
/// </summary>
public partial class RL_ec55ed22dae89075d036f3a863173164 : GenericRecordList<RC_515e950fe4b29206769e5475135e301d>, IEnumerable, IEnumerator {

protected override RC_515e950fe4b29206769e5475135e301d GetElementDefaultValue() {
return new RC_515e950fe4b29206769e5475135e301d();
}

public T[] ToArray<T>(Func<RC_515e950fe4b29206769e5475135e301d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ec55ed22dae89075d036f3a863173164 recordList, Func<RC_515e950fe4b29206769e5475135e301d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ec55ed22dae89075d036f3a863173164(RC_515e950fe4b29206769e5475135e301d[] array) {
  RL_ec55ed22dae89075d036f3a863173164 result = new RL_ec55ed22dae89075d036f3a863173164();
result.InnerFromArray(array);
    return result;
}

public static RL_ec55ed22dae89075d036f3a863173164 ToList<T>(T[] array, Func <T, RC_515e950fe4b29206769e5475135e301d> converter) {
  RL_ec55ed22dae89075d036f3a863173164 result = new RL_ec55ed22dae89075d036f3a863173164();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ec55ed22dae89075d036f3a863173164 FromRestList<T>(RestList<T> restList, Func <T, RC_515e950fe4b29206769e5475135e301d> converter) {
  RL_ec55ed22dae89075d036f3a863173164 result = new RL_ec55ed22dae89075d036f3a863173164();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ec55ed22dae89075d036f3a863173164() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(25,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_515e950fe4b29206769e5475135e301d> NewList() {
return new RL_ec55ed22dae89075d036f3a863173164();
}


} // RL_ec55ed22dae89075d036f3a863173164
}

