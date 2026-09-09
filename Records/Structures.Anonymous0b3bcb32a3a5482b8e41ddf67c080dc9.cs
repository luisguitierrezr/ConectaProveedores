namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Mss7C6WjK0iOQd32fAgNyQ)
///  <code>RC_1b08a2c1cecef1e3b3006a60b97fc68e</code> that represent
/// s <code>Project_Asset_ServiceRecord</code> <p>Description: </p>
/// </summary>
// Name: Project_Asset_ServiceRecord
public partial struct RC_1b08a2c1cecef1e3b3006a60b97fc68e : ITypedRecord<RC_1b08a2c1cecef1e3b3006a60b97fc68e> {
internal static readonly GlobalObjectKey IdProject_Asset_Service = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*waIIG87O4_GzAGpguX_Gjg");

public EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord ssENProject_Asset_Service;


public static implicit operator EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord( RC_1b08a2c1cecef1e3b3006a60b97fc68e r) {
return r.ssENProject_Asset_Service;
}

public static implicit operator RC_1b08a2c1cecef1e3b3006a60b97fc68e (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord r) {
RC_1b08a2c1cecef1e3b3006a60b97fc68e res = new RC_1b08a2c1cecef1e3b3006a60b97fc68e ();
res.ssENProject_Asset_Service = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENProject_Asset_Service.ChangedAttributes = value;
}
get {
    return ssENProject_Asset_Service.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_1b08a2c1cecef1e3b3006a60b97fc68e() {
OptimizedAttributes = null;
ssENProject_Asset_Service = new EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENProject_Asset_Service.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENProject_Asset_Service.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENProject_Asset_Service.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENProject_Asset_Service.Read( r, ref index);
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
public void ReadIM(RC_1b08a2c1cecef1e3b3006a60b97fc68e r) {
this = r;
}


public static bool operator == (RC_1b08a2c1cecef1e3b3006a60b97fc68e a, RC_1b08a2c1cecef1e3b3006a60b97fc68e b) {
if (a.ssENProject_Asset_Service != b.ssENProject_Asset_Service) return false;
return true;
}

public static bool operator != (RC_1b08a2c1cecef1e3b3006a60b97fc68e a, RC_1b08a2c1cecef1e3b3006a60b97fc68e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1b08a2c1cecef1e3b3006a60b97fc68e)) return false;
return (this == (RC_1b08a2c1cecef1e3b3006a60b97fc68e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENProject_Asset_Service.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENProject_Asset_Service.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENProject_Asset_Service.InternalRecursiveSave();
}


public RC_1b08a2c1cecef1e3b3006a60b97fc68e Duplicate() {
RC_1b08a2c1cecef1e3b3006a60b97fc68e t;
t.ssENProject_Asset_Service = (EN_c092eb57986a0debaa22aa8b8546b9c4EntityRecord)this.ssENProject_Asset_Service.Duplicate();
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
if (head == "project_asset_service") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Project_Asset_Service")) variable.Value = ssENProject_Asset_Service; else variable.Optimized = true;
variable.SetFieldName("project_asset_service");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENProject_Asset_Service.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENProject_Asset_Service.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdProject_Asset_Service) {
return ssENProject_Asset_Service;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdProject_Asset_Service.Key.AsGuid) {
return ssENProject_Asset_Service;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENProject_Asset_Service.FillFromOther((IRecord) other.AttributeGet(IdProject_Asset_Service));
}
} // RC_1b08a2c1cecef1e3b3006a60b97fc68e
/// <summary>
/// RecordList type <code>Project_Asset_ServiceRecordList</code> that represents a record list of
///  <code>Project_Asset_Service</code>
/// </summary>
public partial class RL_39dc6f4415ce9196844d0ada601cc72b : GenericRecordList<RC_1b08a2c1cecef1e3b3006a60b97fc68e>, IEnumerable, IEnumerator {

protected override RC_1b08a2c1cecef1e3b3006a60b97fc68e GetElementDefaultValue() {
return new RC_1b08a2c1cecef1e3b3006a60b97fc68e();
}

public T[] ToArray<T>(Func<RC_1b08a2c1cecef1e3b3006a60b97fc68e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_39dc6f4415ce9196844d0ada601cc72b recordList, Func<RC_1b08a2c1cecef1e3b3006a60b97fc68e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_39dc6f4415ce9196844d0ada601cc72b(RC_1b08a2c1cecef1e3b3006a60b97fc68e[] array) {
  RL_39dc6f4415ce9196844d0ada601cc72b result = new RL_39dc6f4415ce9196844d0ada601cc72b();
result.InnerFromArray(array);
    return result;
}

public static RL_39dc6f4415ce9196844d0ada601cc72b ToList<T>(T[] array, Func <T, RC_1b08a2c1cecef1e3b3006a60b97fc68e> converter) {
  RL_39dc6f4415ce9196844d0ada601cc72b result = new RL_39dc6f4415ce9196844d0ada601cc72b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_39dc6f4415ce9196844d0ada601cc72b FromRestList<T>(RestList<T> restList, Func <T, RC_1b08a2c1cecef1e3b3006a60b97fc68e> converter) {
  RL_39dc6f4415ce9196844d0ada601cc72b result = new RL_39dc6f4415ce9196844d0ada601cc72b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_39dc6f4415ce9196844d0ada601cc72b() : base() {
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
protected override OSList<RC_1b08a2c1cecef1e3b3006a60b97fc68e> NewList() {
return new RL_39dc6f4415ce9196844d0ada601cc72b();
}


} // RL_39dc6f4415ce9196844d0ada601cc72b
}

