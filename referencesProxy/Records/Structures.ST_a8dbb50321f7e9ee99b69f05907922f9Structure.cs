namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [ReferenceStructure] TI_WXD_In (wD2nSLjpd0uJ5IJFAo_qmg)
///  <code>ST_a8dbb50321f7e9ee99b69f05907922f9Structure</code> that represents <code>TI_WXD_In</code
/// > <p>Description: </p>
/// </summary>
// Name: TI_WXD_In
public partial struct ST_a8dbb50321f7e9ee99b69f05907922f9Structure : ITypedRecord<ST_a8dbb50321f7e9ee99b69f05907922f9Structure> {
internal static readonly GlobalObjectKey IdSPLIT_KEY = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*Q2yEn+bX3EuNPk3y0VHOaw");
internal static readonly GlobalObjectKey IdWI_TAX_TYPE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*4TEOFgTa70e4B1FiBJ7XSA");
internal static readonly GlobalObjectKey IdWI_TAX_CODE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*S_2SwCwU7UqEyFTstcbDWw");
internal static readonly GlobalObjectKey IdWI_TAX_BASE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*r4s0lgz2Ck69wUH9EX25Ug");

public int ssSPLIT_KEY;

public string ssWI_TAX_TYPE;

public string ssWI_TAX_CODE;

public decimal ssWI_TAX_BASE;


public BitArray OptimizedAttributes;

public ST_a8dbb50321f7e9ee99b69f05907922f9Structure() {
OptimizedAttributes = null;
ssSPLIT_KEY = -2147483648;
ssWI_TAX_TYPE = "";
ssWI_TAX_CODE = "";
ssWI_TAX_BASE = -79228162514264337593543950335m;
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
ssSPLIT_KEY = r.ReadInteger(index++, "TI_WXD_In.SPLIT_KEY", 0);
ssWI_TAX_TYPE = r.ReadText(index++, "TI_WXD_In.WI_TAX_TYPE", "");
ssWI_TAX_CODE = r.ReadText(index++, "TI_WXD_In.WI_TAX_CODE", "");
ssWI_TAX_BASE = r.ReadDecimal(index++, "TI_WXD_In.WI_TAX_BASE", 0.0M);
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
public void ReadIM(ST_a8dbb50321f7e9ee99b69f05907922f9Structure r) {
this = r;
}


public static bool operator == (ST_a8dbb50321f7e9ee99b69f05907922f9Structure a, ST_a8dbb50321f7e9ee99b69f05907922f9Structure b) {
if (a.ssSPLIT_KEY != b.ssSPLIT_KEY) return false;
if (a.ssWI_TAX_TYPE != b.ssWI_TAX_TYPE) return false;
if (a.ssWI_TAX_CODE != b.ssWI_TAX_CODE) return false;
if (a.ssWI_TAX_BASE != b.ssWI_TAX_BASE) return false;
return true;
}

public static bool operator != (ST_a8dbb50321f7e9ee99b69f05907922f9Structure a, ST_a8dbb50321f7e9ee99b69f05907922f9Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_a8dbb50321f7e9ee99b69f05907922f9Structure)) return false;
return (this == (ST_a8dbb50321f7e9ee99b69f05907922f9Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSPLIT_KEY.GetHashCode()
 ^ ssWI_TAX_TYPE.GetHashCode()
 ^ ssWI_TAX_CODE.GetHashCode()
 ^ ssWI_TAX_BASE.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_a8dbb50321f7e9ee99b69f05907922f9Structure Duplicate() {
ST_a8dbb50321f7e9ee99b69f05907922f9Structure t;
t.ssSPLIT_KEY = this.ssSPLIT_KEY;
t.ssWI_TAX_TYPE = this.ssWI_TAX_TYPE;
t.ssWI_TAX_CODE = this.ssWI_TAX_CODE;
t.ssWI_TAX_BASE = this.ssWI_TAX_BASE;
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
if (head == "split_key") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SPLIT_KEY")) variable.Value = ssSPLIT_KEY; else variable.Optimized = true;
} else if (head == "wi_tax_type") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WI_TAX_TYPE")) variable.Value = ssWI_TAX_TYPE; else variable.Optimized = true;
} else if (head == "wi_tax_code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WI_TAX_CODE")) variable.Value = ssWI_TAX_CODE; else variable.Optimized = true;
} else if (head == "wi_tax_base") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".WI_TAX_BASE")) variable.Value = ssWI_TAX_BASE; else variable.Optimized = true;
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
if (key == IdSPLIT_KEY) {
return ssSPLIT_KEY;
}
if (key == IdWI_TAX_TYPE) {
return ssWI_TAX_TYPE;
}
if (key == IdWI_TAX_CODE) {
return ssWI_TAX_CODE;
}
if (key == IdWI_TAX_BASE) {
return ssWI_TAX_BASE;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSPLIT_KEY.Key.AsGuid) {
return ssSPLIT_KEY;
}
if (attributeKey == IdWI_TAX_TYPE.Key.AsGuid) {
return ssWI_TAX_TYPE;
}
if (attributeKey == IdWI_TAX_CODE.Key.AsGuid) {
return ssWI_TAX_CODE;
}
if (attributeKey == IdWI_TAX_BASE.Key.AsGuid) {
return ssWI_TAX_BASE;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSPLIT_KEY = (int) other.AttributeGet(IdSPLIT_KEY);
ssWI_TAX_TYPE = (string) other.AttributeGet(IdWI_TAX_TYPE);
ssWI_TAX_CODE = (string) other.AttributeGet(IdWI_TAX_CODE);
ssWI_TAX_BASE = (decimal) other.AttributeGet(IdWI_TAX_BASE);
}
} // ST_a8dbb50321f7e9ee99b69f05907922f9Structure
/// <summary>
/// RecordList type <code>TI_WXD_InList</code> that represents a record list of <code>TI_WXD_In</code>
/// </summary>
public partial class RL_f2d9c802fb1adc89fda1ad392c027309 : GenericRecordList<ST_a8dbb50321f7e9ee99b69f05907922f9Structure>, IEnumerable, IEnumerator {

protected override ST_a8dbb50321f7e9ee99b69f05907922f9Structure GetElementDefaultValue() {
return new ST_a8dbb50321f7e9ee99b69f05907922f9Structure();
}

public T[] ToArray<T>(Func<ST_a8dbb50321f7e9ee99b69f05907922f9Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f2d9c802fb1adc89fda1ad392c027309 recordList, Func<ST_a8dbb50321f7e9ee99b69f05907922f9Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f2d9c802fb1adc89fda1ad392c027309(ST_a8dbb50321f7e9ee99b69f05907922f9Structure[] array) {
  RL_f2d9c802fb1adc89fda1ad392c027309 result = new RL_f2d9c802fb1adc89fda1ad392c027309();
result.InnerFromArray(array);
    return result;
}

public static RL_f2d9c802fb1adc89fda1ad392c027309 ToList<T>(T[] array, Func <T, ST_a8dbb50321f7e9ee99b69f05907922f9Structure> converter) {
  RL_f2d9c802fb1adc89fda1ad392c027309 result = new RL_f2d9c802fb1adc89fda1ad392c027309();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f2d9c802fb1adc89fda1ad392c027309 FromRestList<T>(RestList<T> restList, Func <T, ST_a8dbb50321f7e9ee99b69f05907922f9Structure> converter) {
  RL_f2d9c802fb1adc89fda1ad392c027309 result = new RL_f2d9c802fb1adc89fda1ad392c027309();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f2d9c802fb1adc89fda1ad392c027309() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_a8dbb50321f7e9ee99b69f05907922f9Structure> NewList() {
return new RL_f2d9c802fb1adc89fda1ad392c027309();
}


} // RL_f2d9c802fb1adc89fda1ad392c027309
}

