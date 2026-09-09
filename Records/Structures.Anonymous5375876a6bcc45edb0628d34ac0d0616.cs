namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (aod1U8xr7UWwYo00rA0GFg)
///  <code>RC_9ae567d0cf6d3095d7119747b95be259</code> that represent
/// s <code>InvoiceFolioInvoiceFileOrderAccConceptsOrderMainAccountingDataTypeRecord</code>
///  <p>Description: </p>
/// </summary>
// Name: InvoiceFolioInvoiceFileOrderAccConceptsOrderMainAccountingDataTypeRecord
public partial struct RC_9ae567d0cf6d3095d7119747b95be259 : ITypedRecord<RC_9ae567d0cf6d3095d7119747b95be259> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdInvoiceFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+AqZGHFv6WkrcStGjhO5Rw");
internal static readonly GlobalObjectKey IdOrderAccConcepts = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GWia3F+CiO7roBGSrpsYkA");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdAccountingDataType = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*etEiohArUeXSV_ovWJJJnA");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile;

public EN_3e07a23619060cc7dc5624548803f5fdEntityRecord ssENOrderAccConcepts;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord ssENAccountingDataType;


public BitArray OptimizedAttributes;

public RC_9ae567d0cf6d3095d7119747b95be259() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENInvoiceFile = new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
ssENOrderAccConcepts = new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENAccountingDataType = new EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[6];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(8,false);
    all[3] = new BitArray(14,false);
    all[4] = new BitArray(29,false);
    all[5] = new BitArray(5,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceFile.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENOrderAccConcepts.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENAccountingDataType.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENInvoiceFile.OptimizedAttributes = value[2];
    ssENOrderAccConcepts.OptimizedAttributes = value[3];
    ssENOrderMain.OptimizedAttributes = value[4];
    ssENAccountingDataType.OptimizedAttributes = value[5];
    }
}
get{
    BitArray[] all = new BitArray[6];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENInvoiceFile.OptimizedAttributes;
    all[3] = ssENOrderAccConcepts.OptimizedAttributes;
    all[4] = ssENOrderMain.OptimizedAttributes;
    all[5] = ssENAccountingDataType.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoice.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENInvoiceFile.Read( r, ref index);
ssENOrderAccConcepts.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENAccountingDataType.Read( r, ref index);
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
public void ReadIM(RC_9ae567d0cf6d3095d7119747b95be259 r) {
this = r;
}


public static bool operator == (RC_9ae567d0cf6d3095d7119747b95be259 a, RC_9ae567d0cf6d3095d7119747b95be259 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENInvoiceFile != b.ssENInvoiceFile) return false;
if (a.ssENOrderAccConcepts != b.ssENOrderAccConcepts) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENAccountingDataType != b.ssENAccountingDataType) return false;
return true;
}

public static bool operator != (RC_9ae567d0cf6d3095d7119747b95be259 a, RC_9ae567d0cf6d3095d7119747b95be259 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_9ae567d0cf6d3095d7119747b95be259)) return false;
return (this == (RC_9ae567d0cf6d3095d7119747b95be259)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENInvoiceFile.GetHashCode()
 ^ ssENOrderAccConcepts.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENAccountingDataType.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENFolio.RecursiveReset();
ssENInvoiceFile.RecursiveReset();
ssENOrderAccConcepts.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENAccountingDataType.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENInvoiceFile.InternalRecursiveSave();
ssENOrderAccConcepts.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENAccountingDataType.InternalRecursiveSave();
}


public RC_9ae567d0cf6d3095d7119747b95be259 Duplicate() {
RC_9ae567d0cf6d3095d7119747b95be259 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENInvoiceFile = (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord)this.ssENInvoiceFile.Duplicate();
t.ssENOrderAccConcepts = (EN_3e07a23619060cc7dc5624548803f5fdEntityRecord)this.ssENOrderAccConcepts.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENAccountingDataType = (EN_1a6e61f23608fb50bfdbc36bcf040caeEntityRecord)this.ssENAccountingDataType.Duplicate();
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
if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "invoicefile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceFile")) variable.Value = ssENInvoiceFile; else variable.Optimized = true;
variable.SetFieldName("invoicefile");
} else if (head == "orderaccconcepts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderAccConcepts")) variable.Value = ssENOrderAccConcepts; else variable.Optimized = true;
variable.SetFieldName("orderaccconcepts");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "accountingdatatype") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingDataType")) variable.Value = ssENAccountingDataType; else variable.Optimized = true;
variable.SetFieldName("accountingdatatype");
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
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdInvoiceFile) {
return ssENInvoiceFile;
}
if (key == IdOrderAccConcepts) {
return ssENOrderAccConcepts;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdAccountingDataType) {
return ssENAccountingDataType;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdInvoiceFile.Key.AsGuid) {
return ssENInvoiceFile;
}
if (attributeKey == IdOrderAccConcepts.Key.AsGuid) {
return ssENOrderAccConcepts;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdAccountingDataType.Key.AsGuid) {
return ssENAccountingDataType;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENInvoiceFile.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFile));
ssENOrderAccConcepts.FillFromOther((IRecord) other.AttributeGet(IdOrderAccConcepts));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENAccountingDataType.FillFromOther((IRecord) other.AttributeGet(IdAccountingDataType));
}
} // RC_9ae567d0cf6d3095d7119747b95be259
/// <summary>
/// RecordList type
///  <code>InvoiceFolioInvoiceFileOrderAccConceptsOrderMainAccountingDataTypeRecordList</code> tha
/// t represents a record list of <code>Invoice, Folio, InvoiceFile, OrderAccConcepts, OrderMain,
///  AccountingDataType</code>
/// </summary>
public partial class RL_fdf4c80e3fbd3f0ec2f926acd9363b33 : GenericRecordList<RC_9ae567d0cf6d3095d7119747b95be259>, IEnumerable, IEnumerator {

protected override RC_9ae567d0cf6d3095d7119747b95be259 GetElementDefaultValue() {
return new RC_9ae567d0cf6d3095d7119747b95be259();
}

public T[] ToArray<T>(Func<RC_9ae567d0cf6d3095d7119747b95be259, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fdf4c80e3fbd3f0ec2f926acd9363b33 recordList, Func<RC_9ae567d0cf6d3095d7119747b95be259, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fdf4c80e3fbd3f0ec2f926acd9363b33(RC_9ae567d0cf6d3095d7119747b95be259[] array) {
  RL_fdf4c80e3fbd3f0ec2f926acd9363b33 result = new RL_fdf4c80e3fbd3f0ec2f926acd9363b33();
result.InnerFromArray(array);
    return result;
}

public static RL_fdf4c80e3fbd3f0ec2f926acd9363b33 ToList<T>(T[] array, Func <T, RC_9ae567d0cf6d3095d7119747b95be259> converter) {
  RL_fdf4c80e3fbd3f0ec2f926acd9363b33 result = new RL_fdf4c80e3fbd3f0ec2f926acd9363b33();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fdf4c80e3fbd3f0ec2f926acd9363b33 FromRestList<T>(RestList<T> restList, Func <T, RC_9ae567d0cf6d3095d7119747b95be259> converter) {
  RL_fdf4c80e3fbd3f0ec2f926acd9363b33 result = new RL_fdf4c80e3fbd3f0ec2f926acd9363b33();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fdf4c80e3fbd3f0ec2f926acd9363b33() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[6];
def[0] = new BitArray(24,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(8,false);
def[3] = new BitArray(14,false);
def[4] = new BitArray(29,false);
def[5] = new BitArray(5,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_9ae567d0cf6d3095d7119747b95be259> NewList() {
return new RL_fdf4c80e3fbd3f0ec2f926acd9363b33();
}


} // RL_fdf4c80e3fbd3f0ec2f926acd9363b33
}

