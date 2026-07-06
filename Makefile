ARCHS = arm64
TARGET := iphone:clang:16.5:12.0

INSTALL_TARGET_PROCESSES ?=

include $(THEOS)/makefiles/common.mk

LIBRARY_NAME = XueSongProbe

XueSongProbe_FILES = \
	Dump/src/main.cxx

XueSongProbe_CFLAGS = -fobjc-arc -I$(CURDIR)/Dump/include
XueSongProbe_CCFLAGS = -std=c++17 -fno-rtti -I$(CURDIR)/Dump/include

include $(THEOS_MAKE_PATH)/library.mk
