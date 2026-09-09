namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (wS2ybrAnWEOuUhknbNFzAg)
///  <code>RC_c791b0e7f92315f354525a79f511e845</code> that represent
/// s <code>ZTC_GENERA_POLIZA_GRALRespRecord</code> <p>Description: </p>
/// </summary>
// Name: ZTC_GENERA_POLIZA_GRALRespRecord
public partial struct RC_c791b0e7f92315f354525a79f511e845 : ITypedRecord<RC_c791b0e7f92315f354525a79f511e845> {
internal static readonly GlobalObjectKey IdZTC_GENERA_POLIZA_GRALResp = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*57CRxyP58xVUUlp59RHoRQ");

public ST_35778da666b987b02b8cb887e66647a4Structure ssSTZTC_GENERA_POLIZA_GRALResp;


public static implicit operator ST_35778da666b987b02b8cb887e66647a4Structure( RC_c791b0e7f92315f354525a79f511e845 r) {
return r.ssSTZTC_GENERA_POLIZA_GRALResp;
}

public static implicit operator RC_c791b0e7f92315f354525a79f511e845 (ST_35778da666b987b02b8cb887e66647a4Structure r) {
RC_c791b0e7f92315f354525a79f511e845 res = new RC_c791b0e7f92315f354525a79f511e845 ();
res.ssSTZTC_GENERA_POLIZA_GRALResp = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_c791b0e7f92315f354525a79f511e845() {
OptimizedAttributes = null;
ssSTZTC_GENERA_POLIZA_GRALResp = new ST_35778da666b987b02b8cb887e66647a4Structure();
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
    ssSTZTC_GENERA_POLIZA_GRALResp.OptimizedAttributes = value[0];
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
ssSTZTC_GENERA_POLIZA_GRALResp.Read( r, ref index);
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
public void ReadIM(RC_c791b0e7f92315f354525a79f511e845 r) {
this = r;
}


public static bool operator == (RC_c791b0e7f92315f354525a79f511e845 a, RC_c791b0e7f92315f354525a79f511e845 b) {
if (a.ssSTZTC_GENERA_POLIZA_GRALResp != b.ssSTZTC_GENERA_POLIZA_GRALResp) return false;
return true;
}

public static bool operator != (RC_c791b0e7f92315f354525a79f511e845 a, RC_c791b0e7f92315f354525a79f511e845 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c791b0e7f92315f354525a79f511e845)) return false;
return (this == (RC_c791b0e7f92315f354525a79f511e845)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTZTC_GENERA_POLIZA_GRALResp.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTZTC_GENERA_POLIZA_GRALResp.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTZTC_GENERA_POLIZA_GRALResp.InternalRecursiveSave();
}


public RC_c791b0e7f92315f354525a79f511e845 Duplicate() {
RC_c791b0e7f92315f354525a79f511e845 t;
t.ssSTZTC_GENERA_POLIZA_GRALResp = (ST_35778da666b987b02b8cb887e66647a4Structure)this.ssSTZTC_GENERA_POLIZA_GRALResp.Duplicate();
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
if (head == "ztc_genera_poliza_gralresp") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ZTC_GENERA_POLIZA_GRALResp")) variable.Value = ssSTZTC_GENERA_POLIZA_GRALResp; else variable.Optimized = true;
variable.SetFieldName("ztc_genera_poliza_gralresp");
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
if (key == IdZTC_GENERA_POLIZA_GRALResp) {
return ssSTZTC_GENERA_POLIZA_GRALResp;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdZTC_GENERA_POLIZA_GRALResp.Key.AsGuid) {
return ssSTZTC_GENERA_POLIZA_GRALResp;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTZTC_GENERA_POLIZA_GRALResp.FillFromOther((IRecord) other.AttributeGet(IdZTC_GENERA_POLIZA_GRALResp));
}
} // RC_c791b0e7f92315f354525a79f511e845
/// <summary>
/// RecordList type <code>ZTC_GENERA_POLIZA_GRALRespRecordList</code> that represents a record list of
///  <code>ZTC_GENERA_POLIZA_GRALResp</code>
/// </summary>
public partial class RL_f4fa937bc14a3b63a8cd177bdbe49254 : GenericRecordList<RC_c791b0e7f92315f354525a79f511e845>, IEnumerable, IEnumerator {

protected override RC_c791b0e7f92315f354525a79f511e845 GetElementDefaultValue() {
return new RC_c791b0e7f92315f354525a79f511e845();
}

public T[] ToArray<T>(Func<RC_c791b0e7f92315f354525a79f511e845, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f4fa937bc14a3b63a8cd177bdbe49254 recordList, Func<RC_c791b0e7f92315f354525a79f511e845, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f4fa937bc14a3b63a8cd177bdbe49254(RC_c791b0e7f92315f354525a79f511e845[] array) {
  RL_f4fa937bc14a3b63a8cd177bdbe49254 result = new RL_f4fa937bc14a3b63a8cd177bdbe49254();
result.InnerFromArray(array);
    return result;
}

public static RL_f4fa937bc14a3b63a8cd177bdbe49254 ToList<T>(T[] array, Func <T, RC_c791b0e7f92315f354525a79f511e845> converter) {
  RL_f4fa937bc14a3b63a8cd177bdbe49254 result = new RL_f4fa937bc14a3b63a8cd177bdbe49254();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f4fa937bc14a3b63a8cd177bdbe49254 FromRestList<T>(RestList<T> restList, Func <T, RC_c791b0e7f92315f354525a79f511e845> converter) {
  RL_f4fa937bc14a3b63a8cd177bdbe49254 result = new RL_f4fa937bc14a3b63a8cd177bdbe49254();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f4fa937bc14a3b63a8cd177bdbe49254() : base() {
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
protected override OSList<RC_c791b0e7f92315f354525a79f511e845> NewList() {
return new RL_f4fa937bc14a3b63a8cd177bdbe49254();
}


} // RL_f4fa937bc14a3b63a8cd177bdbe49254
}

