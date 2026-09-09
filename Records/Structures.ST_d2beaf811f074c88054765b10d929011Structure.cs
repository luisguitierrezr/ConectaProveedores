namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] ACCOUNT_DETAIL (kDucbQZ6V0i0dX_zUgcbxQ)
///  <code>ST_d2beaf811f074c88054765b10d929011Structure</code> that represent
/// s <code>ACCOUNT_DETAIL</code> <p>Description: </p>
/// </summary>
// Name: ACCOUNT_DETAIL
public partial struct ST_d2beaf811f074c88054765b10d929011Structure : ITypedRecord<ST_d2beaf811f074c88054765b10d929011Structure> {
internal static readonly GlobalObjectKey IdCOMP_CODE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*KZA3OnGvlkWcrZH5uKQq0w");
internal static readonly GlobalObjectKey IdGL_ACCOUNT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*VLhjFQo9hkuxP0vh5I4ltA");
internal static readonly GlobalObjectKey IdSHORT_TEXT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*PPGCWb5al0m+lgAsb78_hg");
internal static readonly GlobalObjectKey IdLONG_TEXT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*5JLFoUqvhkCbe0OI4ovoVA");
internal static readonly GlobalObjectKey IdCHRT_ACCTS = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*kQccIQztVUKphwJsy0Zv9g");
internal static readonly GlobalObjectKey IdBS_ACCOUNT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*zdKi1kTH60elalVXpykhGg");
internal static readonly GlobalObjectKey IdPL_ACCOUNT = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*5ZfxFnkM+USugVOxFK43Gg");
internal static readonly GlobalObjectKey IdACCT_CURR = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*L40wU8dWOkWUGvW2mFWdnw");
internal static readonly GlobalObjectKey IdACCT_CURR_ISO = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*uzqSB6kMSEqz_SOwfzIJFg");
internal static readonly GlobalObjectKey IdTAX_CODE = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*DjHBvEm1rkOcEeSara+tCA");
internal static readonly GlobalObjectKey IdNO_TAX_REQUIRED = GlobalObjectKey.Parse("FvvBXIMuYECDNGg_V11vbA*66fUZccf8ES3+CYxSVuvZg");

public string ssCOMP_CODE;

public string ssGL_ACCOUNT;

public string ssSHORT_TEXT;

public string ssLONG_TEXT;

public string ssCHRT_ACCTS;

public string ssBS_ACCOUNT;

public string ssPL_ACCOUNT;

public string ssACCT_CURR;

public string ssACCT_CURR_ISO;

public string ssTAX_CODE;

public string ssNO_TAX_REQUIRED;


public BitArray OptimizedAttributes;

public ST_d2beaf811f074c88054765b10d929011Structure() {
OptimizedAttributes = null;
ssCOMP_CODE = "";
ssGL_ACCOUNT = "";
ssSHORT_TEXT = "";
ssLONG_TEXT = "";
ssCHRT_ACCTS = "";
ssBS_ACCOUNT = "";
ssPL_ACCOUNT = "";
ssACCT_CURR = "";
ssACCT_CURR_ISO = "";
ssTAX_CODE = "";
ssNO_TAX_REQUIRED = "";
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
ssCOMP_CODE = r.ReadText(index++, "ACCOUNT_DETAIL.COMP_CODE", "");
ssGL_ACCOUNT = r.ReadText(index++, "ACCOUNT_DETAIL.GL_ACCOUNT", "");
ssSHORT_TEXT = r.ReadText(index++, "ACCOUNT_DETAIL.SHORT_TEXT", "");
ssLONG_TEXT = r.ReadText(index++, "ACCOUNT_DETAIL.LONG_TEXT", "");
ssCHRT_ACCTS = r.ReadText(index++, "ACCOUNT_DETAIL.CHRT_ACCTS", "");
ssBS_ACCOUNT = r.ReadText(index++, "ACCOUNT_DETAIL.BS_ACCOUNT", "");
ssPL_ACCOUNT = r.ReadText(index++, "ACCOUNT_DETAIL.PL_ACCOUNT", "");
ssACCT_CURR = r.ReadText(index++, "ACCOUNT_DETAIL.ACCT_CURR", "");
ssACCT_CURR_ISO = r.ReadText(index++, "ACCOUNT_DETAIL.ACCT_CURR_ISO", "");
ssTAX_CODE = r.ReadText(index++, "ACCOUNT_DETAIL.TAX_CODE", "");
ssNO_TAX_REQUIRED = r.ReadText(index++, "ACCOUNT_DETAIL.NO_TAX_REQUIRED", "");
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
public void ReadIM(ST_d2beaf811f074c88054765b10d929011Structure r) {
this = r;
}


public static bool operator == (ST_d2beaf811f074c88054765b10d929011Structure a, ST_d2beaf811f074c88054765b10d929011Structure b) {
if (a.ssCOMP_CODE != b.ssCOMP_CODE) return false;
if (a.ssGL_ACCOUNT != b.ssGL_ACCOUNT) return false;
if (a.ssSHORT_TEXT != b.ssSHORT_TEXT) return false;
if (a.ssLONG_TEXT != b.ssLONG_TEXT) return false;
if (a.ssCHRT_ACCTS != b.ssCHRT_ACCTS) return false;
if (a.ssBS_ACCOUNT != b.ssBS_ACCOUNT) return false;
if (a.ssPL_ACCOUNT != b.ssPL_ACCOUNT) return false;
if (a.ssACCT_CURR != b.ssACCT_CURR) return false;
if (a.ssACCT_CURR_ISO != b.ssACCT_CURR_ISO) return false;
if (a.ssTAX_CODE != b.ssTAX_CODE) return false;
if (a.ssNO_TAX_REQUIRED != b.ssNO_TAX_REQUIRED) return false;
return true;
}

public static bool operator != (ST_d2beaf811f074c88054765b10d929011Structure a, ST_d2beaf811f074c88054765b10d929011Structure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_d2beaf811f074c88054765b10d929011Structure)) return false;
return (this == (ST_d2beaf811f074c88054765b10d929011Structure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssCOMP_CODE.GetHashCode()
 ^ ssGL_ACCOUNT.GetHashCode()
 ^ ssSHORT_TEXT.GetHashCode()
 ^ ssLONG_TEXT.GetHashCode()
 ^ ssCHRT_ACCTS.GetHashCode()
 ^ ssBS_ACCOUNT.GetHashCode()
 ^ ssPL_ACCOUNT.GetHashCode()
 ^ ssACCT_CURR.GetHashCode()
 ^ ssACCT_CURR_ISO.GetHashCode()
 ^ ssTAX_CODE.GetHashCode()
 ^ ssNO_TAX_REQUIRED.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_d2beaf811f074c88054765b10d929011Structure Duplicate() {
ST_d2beaf811f074c88054765b10d929011Structure t;
t.ssCOMP_CODE = this.ssCOMP_CODE;
t.ssGL_ACCOUNT = this.ssGL_ACCOUNT;
t.ssSHORT_TEXT = this.ssSHORT_TEXT;
t.ssLONG_TEXT = this.ssLONG_TEXT;
t.ssCHRT_ACCTS = this.ssCHRT_ACCTS;
t.ssBS_ACCOUNT = this.ssBS_ACCOUNT;
t.ssPL_ACCOUNT = this.ssPL_ACCOUNT;
t.ssACCT_CURR = this.ssACCT_CURR;
t.ssACCT_CURR_ISO = this.ssACCT_CURR_ISO;
t.ssTAX_CODE = this.ssTAX_CODE;
t.ssNO_TAX_REQUIRED = this.ssNO_TAX_REQUIRED;
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
if (head == "comp_code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".COMP_CODE")) variable.Value = ssCOMP_CODE; else variable.Optimized = true;
} else if (head == "gl_account") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".GL_ACCOUNT")) variable.Value = ssGL_ACCOUNT; else variable.Optimized = true;
} else if (head == "short_text") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SHORT_TEXT")) variable.Value = ssSHORT_TEXT; else variable.Optimized = true;
} else if (head == "long_text") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LONG_TEXT")) variable.Value = ssLONG_TEXT; else variable.Optimized = true;
} else if (head == "chrt_accts") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".CHRT_ACCTS")) variable.Value = ssCHRT_ACCTS; else variable.Optimized = true;
} else if (head == "bs_account") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BS_ACCOUNT")) variable.Value = ssBS_ACCOUNT; else variable.Optimized = true;
} else if (head == "pl_account") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PL_ACCOUNT")) variable.Value = ssPL_ACCOUNT; else variable.Optimized = true;
} else if (head == "acct_curr") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ACCT_CURR")) variable.Value = ssACCT_CURR; else variable.Optimized = true;
} else if (head == "acct_curr_iso") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ACCT_CURR_ISO")) variable.Value = ssACCT_CURR_ISO; else variable.Optimized = true;
} else if (head == "tax_code") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TAX_CODE")) variable.Value = ssTAX_CODE; else variable.Optimized = true;
} else if (head == "no_tax_required") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".NO_TAX_REQUIRED")) variable.Value = ssNO_TAX_REQUIRED; else variable.Optimized = true;
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
if (key == IdCOMP_CODE) {
return ssCOMP_CODE;
}
if (key == IdGL_ACCOUNT) {
return ssGL_ACCOUNT;
}
if (key == IdSHORT_TEXT) {
return ssSHORT_TEXT;
}
if (key == IdLONG_TEXT) {
return ssLONG_TEXT;
}
if (key == IdCHRT_ACCTS) {
return ssCHRT_ACCTS;
}
if (key == IdBS_ACCOUNT) {
return ssBS_ACCOUNT;
}
if (key == IdPL_ACCOUNT) {
return ssPL_ACCOUNT;
}
if (key == IdACCT_CURR) {
return ssACCT_CURR;
}
if (key == IdACCT_CURR_ISO) {
return ssACCT_CURR_ISO;
}
if (key == IdTAX_CODE) {
return ssTAX_CODE;
}
if (key == IdNO_TAX_REQUIRED) {
return ssNO_TAX_REQUIRED;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCOMP_CODE.Key.AsGuid) {
return ssCOMP_CODE;
}
if (attributeKey == IdGL_ACCOUNT.Key.AsGuid) {
return ssGL_ACCOUNT;
}
if (attributeKey == IdSHORT_TEXT.Key.AsGuid) {
return ssSHORT_TEXT;
}
if (attributeKey == IdLONG_TEXT.Key.AsGuid) {
return ssLONG_TEXT;
}
if (attributeKey == IdCHRT_ACCTS.Key.AsGuid) {
return ssCHRT_ACCTS;
}
if (attributeKey == IdBS_ACCOUNT.Key.AsGuid) {
return ssBS_ACCOUNT;
}
if (attributeKey == IdPL_ACCOUNT.Key.AsGuid) {
return ssPL_ACCOUNT;
}
if (attributeKey == IdACCT_CURR.Key.AsGuid) {
return ssACCT_CURR;
}
if (attributeKey == IdACCT_CURR_ISO.Key.AsGuid) {
return ssACCT_CURR_ISO;
}
if (attributeKey == IdTAX_CODE.Key.AsGuid) {
return ssTAX_CODE;
}
if (attributeKey == IdNO_TAX_REQUIRED.Key.AsGuid) {
return ssNO_TAX_REQUIRED;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssCOMP_CODE = (string) other.AttributeGet(IdCOMP_CODE);
ssGL_ACCOUNT = (string) other.AttributeGet(IdGL_ACCOUNT);
ssSHORT_TEXT = (string) other.AttributeGet(IdSHORT_TEXT);
ssLONG_TEXT = (string) other.AttributeGet(IdLONG_TEXT);
ssCHRT_ACCTS = (string) other.AttributeGet(IdCHRT_ACCTS);
ssBS_ACCOUNT = (string) other.AttributeGet(IdBS_ACCOUNT);
ssPL_ACCOUNT = (string) other.AttributeGet(IdPL_ACCOUNT);
ssACCT_CURR = (string) other.AttributeGet(IdACCT_CURR);
ssACCT_CURR_ISO = (string) other.AttributeGet(IdACCT_CURR_ISO);
ssTAX_CODE = (string) other.AttributeGet(IdTAX_CODE);
ssNO_TAX_REQUIRED = (string) other.AttributeGet(IdNO_TAX_REQUIRED);
}
} // ST_d2beaf811f074c88054765b10d929011Structure
/// <summary>
/// RecordList type <code>ACCOUNT_DETAILList</code> that represents a record list of
///  <code>ACCOUNT_DETAIL</code>
/// </summary>
public partial class RL_051069f32f8e315cea0c4373b129acb5 : GenericRecordList<ST_d2beaf811f074c88054765b10d929011Structure>, IEnumerable, IEnumerator {

protected override ST_d2beaf811f074c88054765b10d929011Structure GetElementDefaultValue() {
return new ST_d2beaf811f074c88054765b10d929011Structure();
}

public T[] ToArray<T>(Func<ST_d2beaf811f074c88054765b10d929011Structure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_051069f32f8e315cea0c4373b129acb5 recordList, Func<ST_d2beaf811f074c88054765b10d929011Structure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_051069f32f8e315cea0c4373b129acb5(ST_d2beaf811f074c88054765b10d929011Structure[] array) {
  RL_051069f32f8e315cea0c4373b129acb5 result = new RL_051069f32f8e315cea0c4373b129acb5();
result.InnerFromArray(array);
    return result;
}

public static RL_051069f32f8e315cea0c4373b129acb5 ToList<T>(T[] array, Func <T, ST_d2beaf811f074c88054765b10d929011Structure> converter) {
  RL_051069f32f8e315cea0c4373b129acb5 result = new RL_051069f32f8e315cea0c4373b129acb5();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_051069f32f8e315cea0c4373b129acb5 FromRestList<T>(RestList<T> restList, Func <T, ST_d2beaf811f074c88054765b10d929011Structure> converter) {
  RL_051069f32f8e315cea0c4373b129acb5 result = new RL_051069f32f8e315cea0c4373b129acb5();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_051069f32f8e315cea0c4373b129acb5() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_d2beaf811f074c88054765b10d929011Structure> NewList() {
return new RL_051069f32f8e315cea0c4373b129acb5();
}


} // RL_051069f32f8e315cea0c4373b129acb5
}

