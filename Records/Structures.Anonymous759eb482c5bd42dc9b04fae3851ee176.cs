namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (grSedb3F3EKbBPrjhR7hdg)
///  <code>RC_0d7cf510ad0e091abdf9a2eb501fc0e9</code> that represent
/// s <code>CurrencyInvoiceFolioInvoiceExtendedForeignerRecord</code> <p>Description: </p>
/// </summary>
// Name: CurrencyInvoiceFolioInvoiceExtendedForeignerRecord
public partial struct RC_0d7cf510ad0e091abdf9a2eb501fc0e9 : ITypedRecord<RC_0d7cf510ad0e091abdf9a2eb501fc0e9> {
internal static readonly GlobalObjectKey IdCurrency = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*L_BoBOY11sygkvMhxdiojg");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdInvoiceExtendedForeigner = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ve3L3gt1A7QLBORsAwblaw");

public EN_327b52812b8badb247bde4975c10d441EntityRecord ssENCurrency;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord ssENInvoiceExtendedForeigner;


public BitArray OptimizedAttributes;

public RC_0d7cf510ad0e091abdf9a2eb501fc0e9() {
OptimizedAttributes = null;
ssENCurrency = new EN_327b52812b8badb247bde4975c10d441EntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENInvoiceExtendedForeigner = new EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(10,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCurrency.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceExtendedForeigner.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENCurrency.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENFolio.OptimizedAttributes = value[2];
    ssENInvoiceExtendedForeigner.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENCurrency.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENFolio.OptimizedAttributes;
    all[3] = ssENInvoiceExtendedForeigner.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCurrency.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENInvoiceExtendedForeigner.Read( r, ref index);
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
public void ReadIM(RC_0d7cf510ad0e091abdf9a2eb501fc0e9 r) {
this = r;
}


public static bool operator == (RC_0d7cf510ad0e091abdf9a2eb501fc0e9 a, RC_0d7cf510ad0e091abdf9a2eb501fc0e9 b) {
if (a.ssENCurrency != b.ssENCurrency) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENInvoiceExtendedForeigner != b.ssENInvoiceExtendedForeigner) return false;
return true;
}

public static bool operator != (RC_0d7cf510ad0e091abdf9a2eb501fc0e9 a, RC_0d7cf510ad0e091abdf9a2eb501fc0e9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0d7cf510ad0e091abdf9a2eb501fc0e9)) return false;
return (this == (RC_0d7cf510ad0e091abdf9a2eb501fc0e9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCurrency.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENInvoiceExtendedForeigner.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCurrency.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENFolio.RecursiveReset();
ssENInvoiceExtendedForeigner.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCurrency.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENInvoiceExtendedForeigner.InternalRecursiveSave();
}


public RC_0d7cf510ad0e091abdf9a2eb501fc0e9 Duplicate() {
RC_0d7cf510ad0e091abdf9a2eb501fc0e9 t;
t.ssENCurrency = (EN_327b52812b8badb247bde4975c10d441EntityRecord)this.ssENCurrency.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENInvoiceExtendedForeigner = (EN_5d51ce8a7e6e6b880d84c37746eb9086EntityRecord)this.ssENInvoiceExtendedForeigner.Duplicate();
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
if (head == "currency") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Currency")) variable.Value = ssENCurrency; else variable.Optimized = true;
variable.SetFieldName("currency");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "invoiceextendedforeigner") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtendedForeigner")) variable.Value = ssENInvoiceExtendedForeigner; else variable.Optimized = true;
variable.SetFieldName("invoiceextendedforeigner");
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
if (key == IdCurrency) {
return ssENCurrency;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdInvoiceExtendedForeigner) {
return ssENInvoiceExtendedForeigner;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCurrency.Key.AsGuid) {
return ssENCurrency;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdInvoiceExtendedForeigner.Key.AsGuid) {
return ssENInvoiceExtendedForeigner;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCurrency.FillFromOther((IRecord) other.AttributeGet(IdCurrency));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENInvoiceExtendedForeigner.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtendedForeigner));
}
} // RC_0d7cf510ad0e091abdf9a2eb501fc0e9
/// <summary>
/// RecordList type <code>CurrencyInvoiceFolioInvoiceExtendedForeignerRecordList</code> that represents
///  a record list of <code>Currency, Invoice, Folio, InvoiceExtendedForeigner</code>
/// </summary>
public partial class RL_06a48d30ec1735b8ae6350ea4dbe82c6 : GenericRecordList<RC_0d7cf510ad0e091abdf9a2eb501fc0e9>, IEnumerable, IEnumerator {

protected override RC_0d7cf510ad0e091abdf9a2eb501fc0e9 GetElementDefaultValue() {
return new RC_0d7cf510ad0e091abdf9a2eb501fc0e9();
}

public T[] ToArray<T>(Func<RC_0d7cf510ad0e091abdf9a2eb501fc0e9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_06a48d30ec1735b8ae6350ea4dbe82c6 recordList, Func<RC_0d7cf510ad0e091abdf9a2eb501fc0e9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_06a48d30ec1735b8ae6350ea4dbe82c6(RC_0d7cf510ad0e091abdf9a2eb501fc0e9[] array) {
  RL_06a48d30ec1735b8ae6350ea4dbe82c6 result = new RL_06a48d30ec1735b8ae6350ea4dbe82c6();
result.InnerFromArray(array);
    return result;
}

public static RL_06a48d30ec1735b8ae6350ea4dbe82c6 ToList<T>(T[] array, Func <T, RC_0d7cf510ad0e091abdf9a2eb501fc0e9> converter) {
  RL_06a48d30ec1735b8ae6350ea4dbe82c6 result = new RL_06a48d30ec1735b8ae6350ea4dbe82c6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_06a48d30ec1735b8ae6350ea4dbe82c6 FromRestList<T>(RestList<T> restList, Func <T, RC_0d7cf510ad0e091abdf9a2eb501fc0e9> converter) {
  RL_06a48d30ec1735b8ae6350ea4dbe82c6 result = new RL_06a48d30ec1735b8ae6350ea4dbe82c6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_06a48d30ec1735b8ae6350ea4dbe82c6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(5,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(10,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0d7cf510ad0e091abdf9a2eb501fc0e9> NewList() {
return new RL_06a48d30ec1735b8ae6350ea4dbe82c6();
}


} // RL_06a48d30ec1735b8ae6350ea4dbe82c6
}

