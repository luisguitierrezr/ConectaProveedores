namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (nY8olW3sRkK6Z_4M1kxPZg)
///  <code>RC_5a609a7b7b622cde2859ca506690f8db</code> that represent
/// s <code>InvoiceAccountingServicesRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceAccountingServicesRecord
public partial struct RC_5a609a7b7b622cde2859ca506690f8db : ITypedRecord<RC_5a609a7b7b622cde2859ca506690f8db> {
internal static readonly GlobalObjectKey IdInvoiceAccountingServices = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*e5pgWmJ73iwoWcpQZpD42w");

public EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord ssENInvoiceAccountingServices;


public static implicit operator EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord( RC_5a609a7b7b622cde2859ca506690f8db r) {
return r.ssENInvoiceAccountingServices;
}

public static implicit operator RC_5a609a7b7b622cde2859ca506690f8db (EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord r) {
RC_5a609a7b7b622cde2859ca506690f8db res = new RC_5a609a7b7b622cde2859ca506690f8db ();
res.ssENInvoiceAccountingServices = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceAccountingServices.ChangedAttributes = value;
}
get {
    return ssENInvoiceAccountingServices.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_5a609a7b7b622cde2859ca506690f8db() {
OptimizedAttributes = null;
ssENInvoiceAccountingServices = new EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(14,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceAccountingServices.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceAccountingServices.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceAccountingServices.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceAccountingServices.Read( r, ref index);
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
public void ReadIM(RC_5a609a7b7b622cde2859ca506690f8db r) {
this = r;
}


public static bool operator == (RC_5a609a7b7b622cde2859ca506690f8db a, RC_5a609a7b7b622cde2859ca506690f8db b) {
if (a.ssENInvoiceAccountingServices != b.ssENInvoiceAccountingServices) return false;
return true;
}

public static bool operator != (RC_5a609a7b7b622cde2859ca506690f8db a, RC_5a609a7b7b622cde2859ca506690f8db b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5a609a7b7b622cde2859ca506690f8db)) return false;
return (this == (RC_5a609a7b7b622cde2859ca506690f8db)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceAccountingServices.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceAccountingServices.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceAccountingServices.InternalRecursiveSave();
}


public RC_5a609a7b7b622cde2859ca506690f8db Duplicate() {
RC_5a609a7b7b622cde2859ca506690f8db t;
t.ssENInvoiceAccountingServices = (EN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord)this.ssENInvoiceAccountingServices.Duplicate();
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
if (head == "invoiceaccountingservices") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccountingServices")) variable.Value = ssENInvoiceAccountingServices; else variable.Optimized = true;
variable.SetFieldName("invoiceaccountingservices");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingServices.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceAccountingServices.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceAccountingServices) {
return ssENInvoiceAccountingServices;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceAccountingServices.Key.AsGuid) {
return ssENInvoiceAccountingServices;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceAccountingServices.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccountingServices));
}
} // RC_5a609a7b7b622cde2859ca506690f8db
/// <summary>
/// RecordList type <code>InvoiceAccountingServicesRecordList</code> that represents a record list of
///  <code>InvoiceAccountingServices</code>
/// </summary>
public partial class RL_ce67f504f77874aaecc91ad036f8a95a : GenericRecordList<RC_5a609a7b7b622cde2859ca506690f8db>, IEnumerable, IEnumerator {

protected override RC_5a609a7b7b622cde2859ca506690f8db GetElementDefaultValue() {
return new RC_5a609a7b7b622cde2859ca506690f8db();
}

public T[] ToArray<T>(Func<RC_5a609a7b7b622cde2859ca506690f8db, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ce67f504f77874aaecc91ad036f8a95a recordList, Func<RC_5a609a7b7b622cde2859ca506690f8db, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ce67f504f77874aaecc91ad036f8a95a(RC_5a609a7b7b622cde2859ca506690f8db[] array) {
  RL_ce67f504f77874aaecc91ad036f8a95a result = new RL_ce67f504f77874aaecc91ad036f8a95a();
result.InnerFromArray(array);
    return result;
}

public static RL_ce67f504f77874aaecc91ad036f8a95a ToList<T>(T[] array, Func <T, RC_5a609a7b7b622cde2859ca506690f8db> converter) {
  RL_ce67f504f77874aaecc91ad036f8a95a result = new RL_ce67f504f77874aaecc91ad036f8a95a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ce67f504f77874aaecc91ad036f8a95a FromRestList<T>(RestList<T> restList, Func <T, RC_5a609a7b7b622cde2859ca506690f8db> converter) {
  RL_ce67f504f77874aaecc91ad036f8a95a result = new RL_ce67f504f77874aaecc91ad036f8a95a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ce67f504f77874aaecc91ad036f8a95a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(14,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5a609a7b7b622cde2859ca506690f8db> NewList() {
return new RL_ce67f504f77874aaecc91ad036f8a95a();
}


} // RL_ce67f504f77874aaecc91ad036f8a95a
}

