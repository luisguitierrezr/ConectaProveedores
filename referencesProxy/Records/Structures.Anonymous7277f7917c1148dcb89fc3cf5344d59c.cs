namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (kfd3chF83Ei4n8PPU0TVnA)
///  <code>RC_ca50fec91350241da30b622279065c6e</code> that represent
/// s <code>SpecialWorkflowsRecord</code> <p>Description: </p>
/// </summary>
// Name: SpecialWorkflowsRecord
public partial struct RC_ca50fec91350241da30b622279065c6e : ITypedRecord<RC_ca50fec91350241da30b622279065c6e> {
internal static readonly GlobalObjectKey IdSpecialWorkflows = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*yf5QylATHSSjC2IieQZcbg");

public EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord ssENSpecialWorkflows;


public static implicit operator EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord( RC_ca50fec91350241da30b622279065c6e r) {
return r.ssENSpecialWorkflows;
}

public static implicit operator RC_ca50fec91350241da30b622279065c6e (EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord r) {
RC_ca50fec91350241da30b622279065c6e res = new RC_ca50fec91350241da30b622279065c6e ();
res.ssENSpecialWorkflows = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSpecialWorkflows.ChangedAttributes = value;
}
get {
    return ssENSpecialWorkflows.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_ca50fec91350241da30b622279065c6e() {
OptimizedAttributes = null;
ssENSpecialWorkflows = new EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSpecialWorkflows.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSpecialWorkflows.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSpecialWorkflows.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSpecialWorkflows.Read( r, ref index);
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
public void ReadIM(RC_ca50fec91350241da30b622279065c6e r) {
this = r;
}


public static bool operator == (RC_ca50fec91350241da30b622279065c6e a, RC_ca50fec91350241da30b622279065c6e b) {
if (a.ssENSpecialWorkflows != b.ssENSpecialWorkflows) return false;
return true;
}

public static bool operator != (RC_ca50fec91350241da30b622279065c6e a, RC_ca50fec91350241da30b622279065c6e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_ca50fec91350241da30b622279065c6e)) return false;
return (this == (RC_ca50fec91350241da30b622279065c6e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSpecialWorkflows.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSpecialWorkflows.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSpecialWorkflows.InternalRecursiveSave();
}


public RC_ca50fec91350241da30b622279065c6e Duplicate() {
RC_ca50fec91350241da30b622279065c6e t;
t.ssENSpecialWorkflows = (EN_1225cc7d9c16ad5c0cda10edb493a67fEntityRecord)this.ssENSpecialWorkflows.Duplicate();
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
if (head == "specialworkflows") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SpecialWorkflows")) variable.Value = ssENSpecialWorkflows; else variable.Optimized = true;
variable.SetFieldName("specialworkflows");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSpecialWorkflows.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSpecialWorkflows.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSpecialWorkflows) {
return ssENSpecialWorkflows;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSpecialWorkflows.Key.AsGuid) {
return ssENSpecialWorkflows;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSpecialWorkflows.FillFromOther((IRecord) other.AttributeGet(IdSpecialWorkflows));
}
} // RC_ca50fec91350241da30b622279065c6e
/// <summary>
/// RecordList type <code>SpecialWorkflowsRecordList</code> that represents a record list of
///  <code>SpecialWorkflows</code>
/// </summary>
public partial class RL_26f449b2965d31aa3962e2e3f79225f3 : GenericRecordList<RC_ca50fec91350241da30b622279065c6e>, IEnumerable, IEnumerator {

protected override RC_ca50fec91350241da30b622279065c6e GetElementDefaultValue() {
return new RC_ca50fec91350241da30b622279065c6e();
}

public T[] ToArray<T>(Func<RC_ca50fec91350241da30b622279065c6e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_26f449b2965d31aa3962e2e3f79225f3 recordList, Func<RC_ca50fec91350241da30b622279065c6e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_26f449b2965d31aa3962e2e3f79225f3(RC_ca50fec91350241da30b622279065c6e[] array) {
  RL_26f449b2965d31aa3962e2e3f79225f3 result = new RL_26f449b2965d31aa3962e2e3f79225f3();
result.InnerFromArray(array);
    return result;
}

public static RL_26f449b2965d31aa3962e2e3f79225f3 ToList<T>(T[] array, Func <T, RC_ca50fec91350241da30b622279065c6e> converter) {
  RL_26f449b2965d31aa3962e2e3f79225f3 result = new RL_26f449b2965d31aa3962e2e3f79225f3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_26f449b2965d31aa3962e2e3f79225f3 FromRestList<T>(RestList<T> restList, Func <T, RC_ca50fec91350241da30b622279065c6e> converter) {
  RL_26f449b2965d31aa3962e2e3f79225f3 result = new RL_26f449b2965d31aa3962e2e3f79225f3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_26f449b2965d31aa3962e2e3f79225f3() : base() {
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
protected override OSList<RC_ca50fec91350241da30b622279065c6e> NewList() {
return new RL_26f449b2965d31aa3962e2e3f79225f3();
}


} // RL_26f449b2965d31aa3962e2e3f79225f3
}

