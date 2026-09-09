namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] TI_ITEM_In (h7uouXkE20eo6OIPWytlIQ)
///  <code>ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure</code> that represents <code>TI_ITEM_In</code
/// > <p>Description: </p>
/// </summary>
// Name: TI_ITEM_In
public partial struct ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure : ITypedRecord<ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure> {
internal static readonly GlobalObjectKey IdINVOICE_DOC_ITEM = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*S650gtMwEUOi+yNHLQyOBA");
internal static readonly GlobalObjectKey IdPO_NUMBER = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*kzPVkG9FzEmQChnbJRuzUw");
internal static readonly GlobalObjectKey IdPO_ITEM = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*yDsyCfiG7k6HWbgiJZJ5kQ");
internal static readonly GlobalObjectKey IdREF_DOC = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*WRRkX205ckSFOCvCX95XMg");
internal static readonly GlobalObjectKey IdREF_DOC_YEAR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*nTSYWD25E0+882Xv1Jxi6g");
internal static readonly GlobalObjectKey IdREF_DOC_IT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*YFVdFvNmWUmEhJwLdPFjeA");
internal static readonly GlobalObjectKey IdTAX_CODE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Drx3kmtqcUilxtAggUdFtQ");
internal static readonly GlobalObjectKey IdITEM_AMOUNT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*p5RXTvflZ0uS9RJ_Nisgfw");
internal static readonly GlobalObjectKey IdQUANTITY = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*sq1taqwjPkSWAWuFrz9R1A");
internal static readonly GlobalObjectKey IdPO_UNIT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*tVcDkGjjqkOpISPmGQyO4g");

public int ssINVOICE_DOC_ITEM;

public string ssPO_NUMBER;

public int ssPO_ITEM;

public string ssREF_DOC;

public int ssREF_DOC_YEAR;

public int ssREF_DOC_IT;

public string ssTAX_CODE;

public decimal ssITEM_AMOUNT;

public decimal ssQUANTITY;

public string ssPO_UNIT;


public BitArray OptimizedAttributes;

public ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure() {
OptimizedAttributes = null;
ssINVOICE_DOC_ITEM = -2147483648;
ssPO_NUMBER = "";
ssPO_ITEM = -2147483648;
ssREF_DOC = "";
ssREF_DOC_YEAR = -2147483648;
ssREF_DOC_IT = -2147483648;
ssTAX_CODE = "";
ssITEM_AMOUNT = -79228162514264337593543950335m;
ssQUANTITY = -79228162514264337593543950335m;
ssPO_UNIT = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssINVOICE_DOC_ITEM = r.ReadInteger(index++, "TI_ITEM_In.INVOICE_DOC_ITEM", 0);
ssPO_NUMBER = r.ReadText(index++, "TI_ITEM_In.PO_NUMBER", "");
ssPO_ITEM = r.ReadInteger(index++, "TI_ITEM_In.PO_ITEM", 0);
ssREF_DOC = r.ReadText(index++, "TI_ITEM_In.REF_DOC", "");
ssREF_DOC_YEAR = r.ReadInteger(index++, "TI_ITEM_In.REF_DOC_YEAR", 0);
ssREF_DOC_IT = r.ReadInteger(index++, "TI_ITEM_In.REF_DOC_IT", 0);
ssTAX_CODE = r.ReadText(index++, "TI_ITEM_In.TAX_CODE", "");
ssITEM_AMOUNT = r.ReadDecimal(index++, "TI_ITEM_In.ITEM_AMOUNT", 0.0M);
ssQUANTITY = r.ReadDecimal(index++, "TI_ITEM_In.QUANTITY", 0.0M);
ssPO_UNIT = r.ReadText(index++, "TI_ITEM_In.PO_UNIT", "");
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
public void ReadIM(ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure r) {
this = r;
}


public static bool operator == (ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure a, ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure b) {
if (a.ssINVOICE_DOC_ITEM != b.ssINVOICE_DOC_ITEM) return false;
if (a.ssPO_NUMBER != b.ssPO_NUMBER) return false;
if (a.ssPO_ITEM != b.ssPO_ITEM) return false;
if (a.ssREF_DOC != b.ssREF_DOC) return false;
if (a.ssREF_DOC_YEAR != b.ssREF_DOC_YEAR) return false;
if (a.ssREF_DOC_IT != b.ssREF_DOC_IT) return false;
if (a.ssTAX_CODE != b.ssTAX_CODE) return false;
if (a.ssITEM_AMOUNT != b.ssITEM_AMOUNT) return false;
if (a.ssQUANTITY != b.ssQUANTITY) return false;
if (a.ssPO_UNIT != b.ssPO_UNIT) return false;
return true;
}

public static bool operator != (ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure a, ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure)) return false;
return (this == (ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssINVOICE_DOC_ITEM.GetHashCode()
 ^ ssPO_NUMBER.GetHashCode()
 ^ ssPO_ITEM.GetHashCode()
 ^ ssREF_DOC.GetHashCode()
 ^ ssREF_DOC_YEAR.GetHashCode()
 ^ ssREF_DOC_IT.GetHashCode()
 ^ ssTAX_CODE.GetHashCode()
 ^ ssITEM_AMOUNT.GetHashCode()
 ^ ssQUANTITY.GetHashCode()
 ^ ssPO_UNIT.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure Duplicate() {
ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure t;
t.ssINVOICE_DOC_ITEM = this.ssINVOICE_DOC_ITEM;
t.ssPO_NUMBER = this.ssPO_NUMBER;
t.ssPO_ITEM = this.ssPO_ITEM;
t.ssREF_DOC = this.ssREF_DOC;
t.ssREF_DOC_YEAR = this.ssREF_DOC_YEAR;
t.ssREF_DOC_IT = this.ssREF_DOC_IT;
t.ssTAX_CODE = this.ssTAX_CODE;
t.ssITEM_AMOUNT = this.ssITEM_AMOUNT;
t.ssQUANTITY = this.ssQUANTITY;
t.ssPO_UNIT = this.ssPO_UNIT;
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
if (head == "invoice_doc_item") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".INVOICE_DOC_ITEM")) variable.Value = ssINVOICE_DOC_ITEM; else variable.Optimized = true;
} else if (head == "po_number") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_NUMBER")) variable.Value = ssPO_NUMBER; else variable.Optimized = true;
} else if (head == "po_item") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_ITEM")) variable.Value = ssPO_ITEM; else variable.Optimized = true;
} else if (head == "ref_doc") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".REF_DOC")) variable.Value = ssREF_DOC; else variable.Optimized = true;
} else if (head == "ref_doc_year") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".REF_DOC_YEAR")) variable.Value = ssREF_DOC_YEAR; else variable.Optimized = true;
} else if (head == "ref_doc_it") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".REF_DOC_IT")) variable.Value = ssREF_DOC_IT; else variable.Optimized = true;
} else if (head == "tax_code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TAX_CODE")) variable.Value = ssTAX_CODE; else variable.Optimized = true;
} else if (head == "item_amount") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ITEM_AMOUNT")) variable.Value = ssITEM_AMOUNT; else variable.Optimized = true;
} else if (head == "quantity") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".QUANTITY")) variable.Value = ssQUANTITY; else variable.Optimized = true;
} else if (head == "po_unit") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PO_UNIT")) variable.Value = ssPO_UNIT; else variable.Optimized = true;
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
if (key == IdINVOICE_DOC_ITEM) {
return ssINVOICE_DOC_ITEM;
}
if (key == IdPO_NUMBER) {
return ssPO_NUMBER;
}
if (key == IdPO_ITEM) {
return ssPO_ITEM;
}
if (key == IdREF_DOC) {
return ssREF_DOC;
}
if (key == IdREF_DOC_YEAR) {
return ssREF_DOC_YEAR;
}
if (key == IdREF_DOC_IT) {
return ssREF_DOC_IT;
}
if (key == IdTAX_CODE) {
return ssTAX_CODE;
}
if (key == IdITEM_AMOUNT) {
return ssITEM_AMOUNT;
}
if (key == IdQUANTITY) {
return ssQUANTITY;
}
if (key == IdPO_UNIT) {
return ssPO_UNIT;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdINVOICE_DOC_ITEM.Key.AsGuid) {
return ssINVOICE_DOC_ITEM;
}
if (attributeKey == IdPO_NUMBER.Key.AsGuid) {
return ssPO_NUMBER;
}
if (attributeKey == IdPO_ITEM.Key.AsGuid) {
return ssPO_ITEM;
}
if (attributeKey == IdREF_DOC.Key.AsGuid) {
return ssREF_DOC;
}
if (attributeKey == IdREF_DOC_YEAR.Key.AsGuid) {
return ssREF_DOC_YEAR;
}
if (attributeKey == IdREF_DOC_IT.Key.AsGuid) {
return ssREF_DOC_IT;
}
if (attributeKey == IdTAX_CODE.Key.AsGuid) {
return ssTAX_CODE;
}
if (attributeKey == IdITEM_AMOUNT.Key.AsGuid) {
return ssITEM_AMOUNT;
}
if (attributeKey == IdQUANTITY.Key.AsGuid) {
return ssQUANTITY;
}
if (attributeKey == IdPO_UNIT.Key.AsGuid) {
return ssPO_UNIT;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssINVOICE_DOC_ITEM = (int) other.AttributeGet(IdINVOICE_DOC_ITEM);
ssPO_NUMBER = (string) other.AttributeGet(IdPO_NUMBER);
ssPO_ITEM = (int) other.AttributeGet(IdPO_ITEM);
ssREF_DOC = (string) other.AttributeGet(IdREF_DOC);
ssREF_DOC_YEAR = (int) other.AttributeGet(IdREF_DOC_YEAR);
ssREF_DOC_IT = (int) other.AttributeGet(IdREF_DOC_IT);
ssTAX_CODE = (string) other.AttributeGet(IdTAX_CODE);
ssITEM_AMOUNT = (decimal) other.AttributeGet(IdITEM_AMOUNT);
ssQUANTITY = (decimal) other.AttributeGet(IdQUANTITY);
ssPO_UNIT = (string) other.AttributeGet(IdPO_UNIT);
}
} // ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure
/// <summary>
/// RecordList type <code>TI_ITEM_InList</code> that represents a record list of
///  <code>TI_ITEM_In</code>
/// </summary>
public partial class RL_1c06eebb48d1b54a899c0d33bdf93a52 : GenericRecordList<ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure>, IEnumerable, IEnumerator {

protected override ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure GetElementDefaultValue() {
return new ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure();
}

public T[] ToArray<T>(Func<ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1c06eebb48d1b54a899c0d33bdf93a52 recordList, Func<ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1c06eebb48d1b54a899c0d33bdf93a52(ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure[] array) {
  RL_1c06eebb48d1b54a899c0d33bdf93a52 result = new RL_1c06eebb48d1b54a899c0d33bdf93a52();
result.InnerFromArray(array);
    return result;
}

public static RL_1c06eebb48d1b54a899c0d33bdf93a52 ToList<T>(T[] array, Func <T, ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure> converter) {
  RL_1c06eebb48d1b54a899c0d33bdf93a52 result = new RL_1c06eebb48d1b54a899c0d33bdf93a52();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1c06eebb48d1b54a899c0d33bdf93a52 FromRestList<T>(RestList<T> restList, Func <T, ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure> converter) {
  RL_1c06eebb48d1b54a899c0d33bdf93a52 result = new RL_1c06eebb48d1b54a899c0d33bdf93a52();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1c06eebb48d1b54a899c0d33bdf93a52() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_8d8928c3b1d6b9b5123f6c51624c56b2Structure> NewList() {
return new RL_1c06eebb48d1b54a899c0d33bdf93a52();
}


} // RL_1c06eebb48d1b54a899c0d33bdf93a52
}

