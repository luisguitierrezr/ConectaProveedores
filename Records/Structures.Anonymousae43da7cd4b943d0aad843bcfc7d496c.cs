namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (fNpDrrnU0EOq2EO8_H1JbA)
///  <code>RC_d5bae0a1e64415dc86dedbeae539158c</code> that represent
/// s <code>InvoiceExtendedSelloDigitalRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceExtendedSelloDigitalRecord
public partial struct RC_d5bae0a1e64415dc86dedbeae539158c : ITypedRecord<RC_d5bae0a1e64415dc86dedbeae539158c> {
internal static readonly GlobalObjectKey IdInvoiceExtendedSelloDigital = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*oeC61UTm3BWG3tvq5TkVjA");

public EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord ssENInvoiceExtendedSelloDigital;


public static implicit operator EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord( RC_d5bae0a1e64415dc86dedbeae539158c r) {
return r.ssENInvoiceExtendedSelloDigital;
}

public static implicit operator RC_d5bae0a1e64415dc86dedbeae539158c (EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord r) {
RC_d5bae0a1e64415dc86dedbeae539158c res = new RC_d5bae0a1e64415dc86dedbeae539158c ();
res.ssENInvoiceExtendedSelloDigital = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENInvoiceExtendedSelloDigital.ChangedAttributes = value;
}
get {
    return ssENInvoiceExtendedSelloDigital.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_d5bae0a1e64415dc86dedbeae539158c() {
OptimizedAttributes = null;
ssENInvoiceExtendedSelloDigital = new EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceExtendedSelloDigital.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENInvoiceExtendedSelloDigital.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENInvoiceExtendedSelloDigital.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceExtendedSelloDigital.Read( r, ref index);
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
public void ReadIM(RC_d5bae0a1e64415dc86dedbeae539158c r) {
this = r;
}


public static bool operator == (RC_d5bae0a1e64415dc86dedbeae539158c a, RC_d5bae0a1e64415dc86dedbeae539158c b) {
if (a.ssENInvoiceExtendedSelloDigital != b.ssENInvoiceExtendedSelloDigital) return false;
return true;
}

public static bool operator != (RC_d5bae0a1e64415dc86dedbeae539158c a, RC_d5bae0a1e64415dc86dedbeae539158c b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d5bae0a1e64415dc86dedbeae539158c)) return false;
return (this == (RC_d5bae0a1e64415dc86dedbeae539158c)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceExtendedSelloDigital.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceExtendedSelloDigital.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceExtendedSelloDigital.InternalRecursiveSave();
}


public RC_d5bae0a1e64415dc86dedbeae539158c Duplicate() {
RC_d5bae0a1e64415dc86dedbeae539158c t;
t.ssENInvoiceExtendedSelloDigital = (EN_5d65ad71be8ce0e9ccb95bcaf92c4383EntityRecord)this.ssENInvoiceExtendedSelloDigital.Duplicate();
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
if (head == "invoiceextendedsellodigital") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedSelloDigital")) variable.Value = ssENInvoiceExtendedSelloDigital; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedsellodigital");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedSelloDigital.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENInvoiceExtendedSelloDigital.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdInvoiceExtendedSelloDigital) {
return ssENInvoiceExtendedSelloDigital;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceExtendedSelloDigital.Key.AsGuid) {
return ssENInvoiceExtendedSelloDigital;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoiceExtendedSelloDigital.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedSelloDigital));
}
} // RC_d5bae0a1e64415dc86dedbeae539158c
/// <summary>
/// RecordList type <code>InvoiceExtendedSelloDigitalRecordList</code> that represents a record list of
///  <code>InvoiceExtendedSelloDigital</code>
/// </summary>
public partial class RL_5f6ddbbedd52a55ae6452e6c4929a917 : GenericRecordList<RC_d5bae0a1e64415dc86dedbeae539158c>, IEnumerable, IEnumerator {

protected override RC_d5bae0a1e64415dc86dedbeae539158c GetElementDefaultValue() {
return new RC_d5bae0a1e64415dc86dedbeae539158c();
}

public T[] ToArray<T>(Func<RC_d5bae0a1e64415dc86dedbeae539158c, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5f6ddbbedd52a55ae6452e6c4929a917 recordList, Func<RC_d5bae0a1e64415dc86dedbeae539158c, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5f6ddbbedd52a55ae6452e6c4929a917(RC_d5bae0a1e64415dc86dedbeae539158c[] array) {
  RL_5f6ddbbedd52a55ae6452e6c4929a917 result = new RL_5f6ddbbedd52a55ae6452e6c4929a917();
result.InnerFromArray(array);
    return result;
}

public static RL_5f6ddbbedd52a55ae6452e6c4929a917 ToList<T>(T[] array, Func <T, RC_d5bae0a1e64415dc86dedbeae539158c> converter) {
  RL_5f6ddbbedd52a55ae6452e6c4929a917 result = new RL_5f6ddbbedd52a55ae6452e6c4929a917();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5f6ddbbedd52a55ae6452e6c4929a917 FromRestList<T>(RestList<T> restList, Func <T, RC_d5bae0a1e64415dc86dedbeae539158c> converter) {
  RL_5f6ddbbedd52a55ae6452e6c4929a917 result = new RL_5f6ddbbedd52a55ae6452e6c4929a917();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5f6ddbbedd52a55ae6452e6c4929a917() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d5bae0a1e64415dc86dedbeae539158c> NewList() {
return new RL_5f6ddbbedd52a55ae6452e6c4929a917();
}


} // RL_5f6ddbbedd52a55ae6452e6c4929a917
}

