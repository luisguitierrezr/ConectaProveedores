namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (1_EetSxcxki_LRjeKSsG7Q)
///  <code>RC_4559aa81984c9ba312e6505b4626e6df</code> that represent
/// s <code>ZTC_GENERA_POLIZA_GRALReqRecord</code> <p>Description: </p>
/// </summary>
// Name: ZTC_GENERA_POLIZA_GRALReqRecord
public partial struct RC_4559aa81984c9ba312e6505b4626e6df : ITypedRecord<RC_4559aa81984c9ba312e6505b4626e6df> {
internal static readonly GlobalObjectKey IdZTC_GENERA_POLIZA_GRALReq = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*gapZRUyYo5sS5lBbRibm3w");

public ST_7d9ca3de97b3b074755ccb195cd9efb0Structure ssSTZTC_GENERA_POLIZA_GRALReq;


public static implicit operator ST_7d9ca3de97b3b074755ccb195cd9efb0Structure( RC_4559aa81984c9ba312e6505b4626e6df r) {
return r.ssSTZTC_GENERA_POLIZA_GRALReq;
}

public static implicit operator RC_4559aa81984c9ba312e6505b4626e6df (ST_7d9ca3de97b3b074755ccb195cd9efb0Structure r) {
RC_4559aa81984c9ba312e6505b4626e6df res = new RC_4559aa81984c9ba312e6505b4626e6df ();
res.ssSTZTC_GENERA_POLIZA_GRALReq = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_4559aa81984c9ba312e6505b4626e6df() {
OptimizedAttributes = null;
ssSTZTC_GENERA_POLIZA_GRALReq = new ST_7d9ca3de97b3b074755ccb195cd9efb0Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTZTC_GENERA_POLIZA_GRALReq.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTZTC_GENERA_POLIZA_GRALReq.Read( r, ref index);
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
public void ReadIM(RC_4559aa81984c9ba312e6505b4626e6df r) {
this = r;
}


public static bool operator == (RC_4559aa81984c9ba312e6505b4626e6df a, RC_4559aa81984c9ba312e6505b4626e6df b) {
if (a.ssSTZTC_GENERA_POLIZA_GRALReq != b.ssSTZTC_GENERA_POLIZA_GRALReq) return false;
return true;
}

public static bool operator != (RC_4559aa81984c9ba312e6505b4626e6df a, RC_4559aa81984c9ba312e6505b4626e6df b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_4559aa81984c9ba312e6505b4626e6df)) return false;
return (this == (RC_4559aa81984c9ba312e6505b4626e6df)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZTC_GENERA_POLIZA_GRALReq.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZTC_GENERA_POLIZA_GRALReq.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZTC_GENERA_POLIZA_GRALReq.InternalRecursiveSave();
}


public RC_4559aa81984c9ba312e6505b4626e6df Duplicate() {
RC_4559aa81984c9ba312e6505b4626e6df t;
t.ssSTZTC_GENERA_POLIZA_GRALReq = (ST_7d9ca3de97b3b074755ccb195cd9efb0Structure)this.ssSTZTC_GENERA_POLIZA_GRALReq.Duplicate();
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
if (head == "ztc_genera_poliza_gralreq") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZTC_GENERA_POLIZA_GRALReq")) variable.Value = ssSTZTC_GENERA_POLIZA_GRALReq; else variable.Optimized = true;
variable.SetFieldName("ztc_genera_poliza_gralreq");
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
if (key == IdZTC_GENERA_POLIZA_GRALReq) {
return ssSTZTC_GENERA_POLIZA_GRALReq;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZTC_GENERA_POLIZA_GRALReq.Key.AsGuid) {
return ssSTZTC_GENERA_POLIZA_GRALReq;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZTC_GENERA_POLIZA_GRALReq.FillFromOther((IRecord) other.AttributeGet(IdZTC_GENERA_POLIZA_GRALReq));
}
} // RC_4559aa81984c9ba312e6505b4626e6df
/// <summary>
/// RecordList type <code>ZTC_GENERA_POLIZA_GRALReqRecordList</code> that represents a record list of
///  <code>ZTC_GENERA_POLIZA_GRALReq</code>
/// </summary>
public partial class RL_f43fc8b692c71a86e8e333e9a6d2a803 : GenericRecordList<RC_4559aa81984c9ba312e6505b4626e6df>, IEnumerable, IEnumerator {

protected override RC_4559aa81984c9ba312e6505b4626e6df GetElementDefaultValue() {
return new RC_4559aa81984c9ba312e6505b4626e6df();
}

public T[] ToArray<T>(Func<RC_4559aa81984c9ba312e6505b4626e6df, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f43fc8b692c71a86e8e333e9a6d2a803 recordList, Func<RC_4559aa81984c9ba312e6505b4626e6df, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f43fc8b692c71a86e8e333e9a6d2a803(RC_4559aa81984c9ba312e6505b4626e6df[] array) {
  RL_f43fc8b692c71a86e8e333e9a6d2a803 result = new RL_f43fc8b692c71a86e8e333e9a6d2a803();
result.InnerFromArray(array);
    return result;
}

public static RL_f43fc8b692c71a86e8e333e9a6d2a803 ToList<T>(T[] array, Func <T, RC_4559aa81984c9ba312e6505b4626e6df> converter) {
  RL_f43fc8b692c71a86e8e333e9a6d2a803 result = new RL_f43fc8b692c71a86e8e333e9a6d2a803();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f43fc8b692c71a86e8e333e9a6d2a803 FromRestList<T>(RestList<T> restList, Func <T, RC_4559aa81984c9ba312e6505b4626e6df> converter) {
  RL_f43fc8b692c71a86e8e333e9a6d2a803 result = new RL_f43fc8b692c71a86e8e333e9a6d2a803();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f43fc8b692c71a86e8e333e9a6d2a803() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_4559aa81984c9ba312e6505b4626e6df> NewList() {
return new RL_f43fc8b692c71a86e8e333e9a6d2a803();
}


} // RL_f43fc8b692c71a86e8e333e9a6d2a803
}

